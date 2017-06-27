using HospitalLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalModel
{
    /**
     * Pessoa
     * @Desc: É uma classe base e generica que contem atributos comuns  às subclasess especializadas
    * */
    public class Pessoa
    {
        [Required]
        public String Nome { get; set; }
        [MaxLength(11)]
        [MinLength(11)]
        [CustomValidationCPF(ErrorMessageResourceName = "CPFInvalido")]
        public String Cpf { get; set; }
        public DateTime DataNasc { get; set; }
        [StringLength(12)]
        public String Telefone { get; set; }

    }
}
