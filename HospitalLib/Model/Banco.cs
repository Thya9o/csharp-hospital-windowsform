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
     * Banco
     * @Desc: É o banco obrigatório de um ou mais funcionarios do hospital
    * */
    public class Banco
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(100)]
        [Required]
        public String Nome { get; set; }
        [MaxLength(10)]
        [Required]
        public String Conta { get; set; }
        [MaxLength(10)]
        [Required]
        public String Agencia { get; set; }

        // sobrescreve o ToString para exibir o nome nas grids
        public override string ToString()
        {
            return Nome;
        }

    }
}
