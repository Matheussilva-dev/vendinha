using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Vendinha.Contexts;
using Vendinha.Models;

namespace Vendinha.Services
{
    public class ClienteService
    {
        public const int TamanhoPagina = 10;

        private const string ConnectionStringPadrao =
            "Host=localhost;Port=5432;Database=vendinha;Username=postgres;Password=postgres";

        private VendinhaDbContext context;

        public ClienteService(VendinhaDbContext context)
        {
            this.context = context;
        }

        public ClienteService() : this(new VendinhaDbContext(ObterConnectionString()))
        {
        }

        private static string ObterConnectionString()
        {
            var env = Environment.GetEnvironmentVariable("VENDINHA_CONNECTION");
            return string.IsNullOrWhiteSpace(env) ? ConnectionStringPadrao : env;
        }

        private static DateTime Agora()
        {
            return DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Unspecified);
        }



        private IQueryable<Cliente> Filtrar(string? busca)
        {
            var consulta = context.Clientes.AsNoTracking().AsQueryable();

            if (!string.IsNullOrWhiteSpace(busca))
            {

                consulta = consulta.Where(c => EF.Functions.ILike(c.Nome, $"%{busca.Trim()}%"));
            }

            return consulta;
        }

      
        public List<Cliente> Consultar(string? busca = null, int pagina = 1)
        {
            if (pagina < 1)
            {
                pagina = 1;
            }

            return Filtrar(busca)
                .Include(c => c.Dividas)
                .OrderByDescending(c => c.Dividas.Where(d => !d.Paga).Sum(d => d.Valor))
                .ThenBy(c => c.Nome)
                .Skip((pagina - 1) * TamanhoPagina)
                .Take(TamanhoPagina)
                .ToList();
        }

        public int Contar(string? busca = null)
        {
            return Filtrar(busca).Count();
        }

        public Cliente? ObterPorId(int id)
        {
            return context.Clientes.AsNoTracking().Include(c => c.Dividas).FirstOrDefault(c => c.Id == id);
        }

        public bool Validar(Cliente cliente, out List<ValidationResult> erros)
        {
            var validationContext = new ValidationContext(cliente);
            erros = new List<ValidationResult>();
            return Validator.TryValidateObject(cliente, validationContext, erros, true);
        }

        public bool Criar(Cliente cliente, out List<ValidationResult> erros)
        {
            if (!Validar(cliente, out erros))
            {
                return false;
            }

            if (context.Clientes.Any(c => c.Cpf == cliente.Cpf))
            {
                erros.Add(new ValidationResult(
                    "Já existe um cliente cadastrado com este CPF.", new[] { nameof(Cliente.Cpf) }));
                return false;
            }

            context.Clientes.Add(cliente);
            context.SaveChanges();
            return true;
        }

        public bool Atualizar(Cliente cliente, out List<ValidationResult> erros)
        {
            if (!Validar(cliente, out erros))
            {
                return false;
            }

            var existente = context.Clientes.Find(cliente.Id);
            if (existente == null)
            {
                erros.Add(new ValidationResult("Cliente não encontrado."));
                return false;
            }

            if (context.Clientes.Any(c => c.Cpf == cliente.Cpf && c.Id != cliente.Id))
            {
                erros.Add(new ValidationResult(
                    "Já existe um cliente cadastrado com este CPF.", new[] { nameof(Cliente.Cpf) }));
                return false;
            }

            existente.Nome = cliente.Nome;
            existente.Cpf = cliente.Cpf;
            existente.DataNascimento = cliente.DataNascimento;
            existente.Email = cliente.Email;
            context.SaveChanges();
            return true;
        }

        public bool Excluir(int id)
        {
            var cliente = context.Clientes.Include(c => c.Dividas).FirstOrDefault(c => c.Id == id);
            if (cliente == null)
            {
                return false;
            }

            context.Dividas.RemoveRange(cliente.Dividas);
            context.Clientes.Remove(cliente);
            context.SaveChanges();
            return true;
        }

        // ---------------- Dívidas ----------------

        public List<Divida> ConsultarDividas(int clienteId)
        {
            return context.Dividas
                .AsNoTracking()
                .Where(d => d.ClienteId == clienteId)
                .OrderByDescending(d => d.DataCriacao)
                .ToList();
        }

        public bool CriarDivida(int clienteId, decimal valor, out List<ValidationResult> erros)
        {
            var divida = new Divida
            {
                ClienteId = clienteId,
                Valor = valor,
                Paga = false,
                DataCriacao = Agora(),
            };

            erros = new List<ValidationResult>();
            if (!Validator.TryValidateObject(divida, new ValidationContext(divida), erros, true))
            {
                return false;
            }

            if (!context.Clientes.Any(c => c.Id == clienteId))
            {
                erros.Add(new ValidationResult("Cliente não encontrado."));
                return false;
            }

            // Regra: só pode haver uma dívida em aberto por cliente
            if (context.Dividas.Any(d => d.ClienteId == clienteId && !d.Paga))
            {
                erros.Add(new ValidationResult("O cliente já possui uma dívida em aberto."));
                return false;
            }

            context.Dividas.Add(divida);
            context.SaveChanges();
            return true;
        }

        public bool PagarDivida(int dividaId, out string? erro)
        {
            erro = null;
            var divida = context.Dividas.Find(dividaId);

            if (divida == null)
            {
                erro = "Dívida não encontrada.";
                return false;
            }

            if (divida.Paga)
            {
                erro = "Esta dívida já foi paga.";
                return false;
            }

            divida.Paga = true;
            divida.DataPagamento = Agora();
            context.SaveChanges();
            return true;
        }
    }
}
