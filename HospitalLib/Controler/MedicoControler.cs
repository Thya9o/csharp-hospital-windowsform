using HospitalModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalLib.Controler
{
    public class MedicoControler
    {

        public HospitalContext ctx = new HospitalContext();
        public BancoControler bancoControl = new BancoControler();
        public AreaAtuacaoControler areaControl = new AreaAtuacaoControler();

        // Popula a base com um registro padrao
        public void PopularBase()
        {
            this.SalvarMedico(new Medico()
            {
                Nome = "Medico",
                Crm = "000",
                Banco = bancoControl.getBanco("1"),
                AreaAtuacao = areaControl.getObjeto("1"),
                Turno = "Diurno",
                DataNasc = DateTime.Now,
            });
        }

        // Salva ou atualiza um objeto
        public void SalvarMedico(Medico medico)
        {
            try
            {
                // marca os attributos que são objetos como já existentes evitando a duplicação
                ctx.Entry(medico.Banco).State = System.Data.Entity.EntityState.Unchanged;
                ctx.Entry(medico.AreaAtuacao).State = System.Data.Entity.EntityState.Unchanged;

                if (medico.Id == 0)
                {
                    ctx.Medicos.Add(medico);
                }
                else
                {
                    var tempMedico = ctx.Medicos.SingleOrDefault(m => m.Id == medico.Id);
                    tempMedico.Id = medico.Id;
                    tempMedico.Crm = medico.Crm;
                    tempMedico.Nome = medico.Nome;
                    tempMedico.Cpf = medico.Cpf;
                    tempMedico.Telefone = medico.Telefone;
                    tempMedico.DataNasc = medico.DataNasc;
                    tempMedico.Turno = medico.Turno;
                    tempMedico.Banco = medico.Banco;
                    tempMedico.AreaAtuacao = medico.AreaAtuacao;
                }

                ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                Util.HandleSQLDBException(ex);
            }
        }

        // remove um objeto
        public void RemoverMedico(Medico medico)
        {
            if (medico.Id != 0)
            {
                ctx.Medicos.Remove(ctx.Medicos.Single(m => m.Id == medico.Id));
                ctx.SaveChanges();
            }
        }

        // lista todos os registros
        public IList<Medico> ObterMedicos()
        {
            var medicos = from medico 
                          in ctx.Medicos.Include("Banco").Include("AreaAtuacao")
                          select medico;
            return medicos.ToList();
        }

        // busca um registro especifico
        public Medico getMedico(String StringID)
        {
            int id = int.Parse(StringID);
            var medicos = from medico
                          in ctx.Medicos.Include("Banco").Include("AreaAtuacao")
                          where medico.Id == id
                          select medico;

            return medicos.ToList().ElementAt(0);
        }
    }
}
