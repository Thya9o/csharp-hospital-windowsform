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
     * Consulta
     * @Desc: É a consulta de um paciente com um médico
    * */
    public class Consulta
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public Agendamento Agendamento { get; set; }
        [Required]
        public Paciente Paciente { get; set; }
        [Required]
        public Medico Medico { get; set; }
        [Required]
        public DateTime Data { get; set; }
        [Required]
        public Decimal PrecoTotal { get; set; }

    }
}
