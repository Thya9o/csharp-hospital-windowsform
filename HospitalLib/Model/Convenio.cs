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
     * Convenio
     * @Desc: É o convenio (plano de saúde) de um ou mais pacientes
    * */
    public class Convenio
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(100)]
        [Required]
        public String NomePlano { get; set; }
        [MaxLength(100)]
        [Required]
        public String NomeEmpresa { get; set; }
        public String Telefone { get; set; }

        // sobrescreve o ToString para exibir o nome nas grids
        public override string ToString()
        {
            return NomePlano;
        }

    }
}