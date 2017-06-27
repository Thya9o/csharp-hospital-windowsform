using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalLib
{
    /*
    * Validação customizada para o CPF
    * Criado pelo professor Alex e revista e ajustada por mim
    */
    class CustomValidationCPFAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null || string.IsNullOrWhiteSpace(value.ToString()))
            {
                return true;
            }
            bool valido = ValidarCPF(value.ToString());
            return valido;
        }

        private bool ValidarCPF(string cpf)
        {
            System.Text.RegularExpressions.Regex reg = new System.Text.RegularExpressions.Regex(@"[^0-9]");
            cpf = reg.Replace(cpf, String.Empty);
            if (cpf.Length > 11)
            {
                return false;
            }

            cpf.PadLeft(11, '0');
            int index = cpf.Length - 1;
            while (cpf[index] == cpf[index - 1] && --index > 0) ;    
            if (index < 0)
            {
                return false;
            }

            return true;
        }
    }
}
