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
     * Medico
     * @Desc: O médico é o funcionario responsável por atender os pacientes em consultas
    * */
    public class Medico : Funcionario
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(15)]
        [Required]
        public String Crm { get; set; }
        [Required]
        public AreaAtuacao AreaAtuacao { get; set; }
        [Required]
        public String Turno { get; set; }

        // sobrescreve o ToString para exibir o nome nas grids 
        public override string ToString()
        {
            return Nome;
        }

    }
}
