using System.ComponentModel.DataAnnotations;
using Vendinha.Validacoes;

namespace Vendinha.Models
{
    public class Cliente : IValidatableObject
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome completo é obrigatório.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O nome deve ter entre 3 e 100 caracteres.")]
        public string Nome { get; set; } = string.Empty;

        private string cpf = string.Empty;

        [Required(ErrorMessage = "O CPF é obrigatório.")]
        [CpfValido]
        public string Cpf
        {
            get
            {
                return this.cpf;
            }
            set
            {
                this.cpf = new string((value ?? string.Empty).Where(char.IsDigit).ToArray());
            }
        }

        public DateTime DataNascimento { get; set; }

        private string? email;

        [EmailAddress(ErrorMessage = "E-mail inválido.")]
        public string? Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = string.IsNullOrWhiteSpace(value) ? null : value.Trim().ToLower();
            }
        }

        public List<Divida> Dividas { get; set; } = new List<Divida>();

        public int Idade
        {
            get
            {
                var hoje = DateTime.Today;
                var idade = hoje.Year - DataNascimento.Year;
                if (DataNascimento.Date > hoje.AddYears(-idade))
                {
                    idade--;
                }
                return idade;
            }
        }

        public decimal TotalDividas
        {
            get
            {
                return Dividas.Where(d => !d.Paga).Sum(d => d.Valor);
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (DataNascimento == default || DataNascimento.Date > DateTime.Today)
            {
                yield return new ValidationResult(
                    "Data de nascimento inválida.", new[] { nameof(DataNascimento) });
            }
        }
    }
}
