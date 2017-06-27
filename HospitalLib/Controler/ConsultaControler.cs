using HospitalModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalLib.Controler
{
    public class ConsultaControler
    {
        public HospitalContext ctx = new HospitalContext();

        // Salva ou atualiza um objeto
        public void SalvarObjeto(Consulta objeto)
        {
            try
            {
                // marca os attributos que são objetos como já existentes evitando a duplicação
                ctx.Entry(objeto.Paciente).State = System.Data.Entity.EntityState.Unchanged;
                ctx.Entry(objeto.Paciente.Convenio).State = System.Data.Entity.EntityState.Unchanged;

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

                // seleciona um agendamento ja existente para atribuir ao objeto
                // evitando a duplicação do registro
                var agendamentoQuery = from agendamento
                              in ctx.Agendamentos.Include("Paciente").Include("Medico").Include("Secretaria")
                                       where agendamento.Id == objeto.Agendamento.Id
                                       select agendamento;
                objeto.Agendamento = agendamentoQuery.ToList().ElementAt(0);

                if (objeto.Id == 0)
                {
                    ctx.Consultas.Add(objeto);
                }
                else
                {
                    var tempObjeto = ctx.Consultas.SingleOrDefault(temp => temp.Id == objeto.Id);
                    tempObjeto.Id = objeto.Id;
                    tempObjeto.Paciente = objeto.Paciente;
                    tempObjeto.Medico = objeto.Medico;
                    tempObjeto.Agendamento = objeto.Agendamento;
                    tempObjeto.Data = objeto.Data;
                    tempObjeto.PrecoTotal = objeto.PrecoTotal;
                }

                ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                Util.HandleSQLDBException(ex);
            }
        }

        // remove um objeto
        public void RemoverObjeto(Consulta objeto)
        {
            if (objeto.Id != 0)
            {
                ctx.Consultas.Remove(ctx.Consultas.Single(temp => temp.Id == objeto.Id));
                ctx.SaveChanges();
            }
        }

        // lista todos os registros
        public IList<Consulta> ObterObjetos()
        {
            var objetos = from objeto 
                          in ctx.Consultas.Include("Paciente").Include("Medico").Include("Agendamento").Include("Agendamento.Paciente")
                          select objeto;
            return objetos.ToList();
        }

        // busca um registro especifico
        public Consulta getObjeto(String StringId)
        {

            int id = int.Parse(StringId);
            var selectedObjeto = from objeto
                                 in ctx.Consultas.Include("Paciente").Include("Medico").Include("Agendamento").Include("Agendamento.Paciente")
                                 where objeto.Id == id
                                 select objeto;

            return selectedObjeto.ToList().ElementAt(0);
        }

        // busca todas as consultas de um medico especifico
        public IList<Consulta> getConsultas(Medico medico)
        {
            var objetos = from objeto
                                 in ctx.Consultas.Include("Paciente").Include("Medico").Include("Agendamento").Include("Agendamento.Paciente")
                          where objeto.Medico.Id == medico.Id
                                 select objeto;

            return objetos.ToList();
        }
    }
}
