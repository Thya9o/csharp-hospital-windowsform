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
     * Paciente
     * @Desc: O paciente é a pessoa que sera consultada 
    * */
    public class Paciente : Pessoa
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public Convenio Convenio { get; set; }

        // sobrescreve o ToString para exibir o nome nas grids
        public override string ToString()
        {
            return Nome;
        }

    }
}
