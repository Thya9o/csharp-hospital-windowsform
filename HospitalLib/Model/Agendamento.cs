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
     * Agendamento
     * @Desc: É o agendamento de uma consulta feito por uma secretaria
    * */
    public class Agendamento
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public Paciente Paciente { get; set; }
        [Required]
        public Secretaria Secretaria { get; set; }
        [Required]
        public Medico Medico { get; set; }
        [Required]
        public DateTime DataAgendada { get; set; }
        
        // atributo unico para exibir um nome formatado corretamente nas views
        [NotMapped]
        public string getAgendamento
        {
            get
            {
                return Id + " - " + (Id == 1 ? "Sem Agendamento" : Paciente.Nome);
            }
        }

        // sobrescreve o ToString padrão para exibir um nome formatado na view
        public override string ToString()
        {
            return Id + " - " + (Id == 1 ? "Sem Agendamento" : Paciente.Nome);
        }
    }
}
