using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalModel
{
    /**
     * Secretaria
     * @Desc: É uma funcionaria do setor administrativo, responsável pelo agendamento de consultas
    * */
    public class Secretaria : Funcionario
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        // sobrescreve o ToString para exibir o nome nas grids
        public override string ToString()
        {
            return Nome;
        }

    }
}
