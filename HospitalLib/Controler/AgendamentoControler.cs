using HospitalModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalLib.Controler
{
    public class AgendamentoControler
    {
        public HospitalContext ctx = new HospitalContext();
        public PacienteControler pacienteControl = new PacienteControler();
        public MedicoControler medicoControl = new MedicoControler();
        public SecretariaControler adminControl = new SecretariaControler();

        // Popula a base com um registro padrao
        public void PopularBase()
        {
            this.SalvarObjeto(new Agendamento()
            {
                Paciente = pacienteControl.getObjeto("1"),
                Medico = medicoControl.getMedico("1"),
                Secretaria = adminControl.getObjeto("1"),
                DataAgendada = DateTime.Now,
            });
        }

        // Salva ou atualiza um objeto
        public void SalvarObjeto(Agendamento objeto)
        {
            try
            {
                // marca os attributos que são objetos como já existentes evitando a duplicação
                ctx.Entry(objeto.Paciente).State = System.Data.Entity.EntityState.Unchanged;
                ctx.Entry(objeto.Paciente.Convenio).State = System.Data.Entity.EntityState.Unchanged;
                ctx.Entry(objeto.Secretaria).State = System.Data.Entity.EntityState.Unchanged;
                ctx.Entry(objeto.Secretaria.Banco).State = System.Data.Entity.EntityState.Unchanged;

                //----------
                // Objetos (class) que possuem mais de um objeto (class) aninhado
                // e melhor buscar pelo ctx do que marcar como nao alterado
                //----------

                // seleciona um medico ja existente para atribuir ao objeto
                // evitando a duplicação do registro
                var medicoQuery = from medico
                              in ctx.Medicos.Include("Banco").Include("AreaAtuacao")
                                  where medico.Id == objeto.Medico.Id
                                  select medico;
                objeto.Medico = medicoQuery.ToList().ElementAt(0);

                if (objeto.Id == 0)
                {
                    ctx.Agendamentos.Add(objeto);
                }
                else
                {
                    var tempObjeto = ctx.Agendamentos.SingleOrDefault(temp => temp.Id == objeto.Id);
                    tempObjeto.Id = objeto.Id;
                    tempObjeto.Paciente = objeto.Paciente;
                    tempObjeto.Medico = objeto.Medico;
                    tempObjeto.Secretaria = objeto.Secretaria;
                    tempObjeto.DataAgendada = objeto.DataAgendada;
                }

                ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                Util.HandleSQLDBException(ex);
            }
        }

        // remove um objeto
        public void RemoverObjeto(Agendamento objeto)
        {
            if (objeto.Id != 0)
            {
                ctx.Agendamentos.Remove(ctx.Agendamentos.Single(temp => temp.Id == objeto.Id));
                ctx.SaveChanges();
            }
        }

        // lista todos os registros
        public IList<Agendamento> ObterObjetos()
        {
            var objetos = from objeto 
                          in ctx.Agendamentos.Include("Paciente").Include("Medico").Include("Secretaria")
                          select objeto;
            return objetos.ToList();
        }

        // busca um registro especifico
        public Agendamento getObjeto(String StringId)
        {

            int id = int.Parse(StringId);
            var selectedObjeto = from objeto
                                 in ctx.Agendamentos.Include("Paciente").Include("Medico").Include("Secretaria").Include("Medico.AreaAtuacao")
                                 where objeto.Id == id
                                 select objeto;

            return selectedObjeto.ToList().ElementAt(0);
        }

        // busca todas os agendamentos de um medico especifico
        public IList<Agendamento> getAgendamentos(Medico medico)
        {
            var objetos = from objeto
                          in ctx.Agendamentos.Include("Paciente").Include("Medico").Include("Secretaria")
                          where objeto.Medico.Id == medico.Id
                          select objeto;

            return objetos.ToList();
        }
    }
}
