using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalModel
{
    /**
     * Funcionário
     * @Desc: É um funcionário genérico com os atributos comum a todos os tipos de funcionários
    * */
    public class Funcionario : Pessoa
    {
        public Banco Banco { get; set; }

    }
}
