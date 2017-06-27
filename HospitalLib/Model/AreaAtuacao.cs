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
     * Area de Atuacao
     * @Desc: É a área de atuação de um médico
    * */
    public class AreaAtuacao
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(100)]
        [Required]
        public String Area { get; set; }
        [Required]
        public Decimal Valor { get; set; }

        // sobrescreve o ToString para exibir o nome nas grids
        public override string ToString()
        {
            return Area;
        }

    }
}
