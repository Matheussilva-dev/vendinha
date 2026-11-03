using System.ComponentModel.DataAnnotations;

namespace Vendinha.Validacoes
{
    /// <summary>Valida se o CPF informado é válido (dígitos verificadores).</summary>
    public class CpfValidoAttribute : ValidationAttribute
    {
        public CpfValidoAttribute() : base("CPF inválido.")
        {
        }

        public override bool IsValid(object? value)
        {
            var cpf = value as string;
            if (string.IsNullOrEmpty(cpf))
            {
                return true; // obrigatoriedade fica por conta do [Required]
            }

            return CpfEhValido(cpf);
        }

        public static bool CpfEhValido(string cpf)
        {
            var digitos = new string(cpf.Where(char.IsDigit).ToArray());

            if (digitos.Length != 11 || digitos.Distinct().Count() == 1)
            {
                return false;
            }

            return CalcularDigito(digitos, 9) == digitos[9] - '0'
                && CalcularDigito(digitos, 10) == digitos[10] - '0';
        }

        private static int CalcularDigito(string digitos, int quantidade)
        {
            var soma = 0;
            for (var i = 0; i < quantidade; i++)
            {
                soma += (digitos[i] - '0') * (quantidade + 1 - i);
            }

            var resto = soma * 10 % 11;
            return resto == 10 ? 0 : resto;
        }
    }
}
