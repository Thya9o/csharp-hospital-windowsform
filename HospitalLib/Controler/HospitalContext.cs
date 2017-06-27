using HospitalModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalLib
{
    public class HospitalContext : DbContext
    {

        public static void Context()
        {
            var type = typeof(System.Data.Entity.SqlServer.SqlProviderServices);
            if (type == null)
            {
                throw new Exception("Nao remova. Força a referencia estatica a biblioteca");
            }
        }

        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Secretaria> Secretarias { get; set; }
        public DbSet<Banco> Bancos { get; set; }
        public DbSet<AreaAtuacao> AreasAtuacao { get; set; }
        public DbSet<Convenio> Convenios { get; set; }
        public DbSet<Agendamento> Agendamentos { get; set; }
        public DbSet<Consulta> Consultas { get; set; }

        public HospitalContext()  : base("name=HospitalModel")
        {

        }
    }
}
