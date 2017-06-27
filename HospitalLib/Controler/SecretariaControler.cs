using HospitalModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalLib.Controler
{
    public class SecretariaControler
    {
        public HospitalContext ctx = new HospitalContext();
        public BancoControler bancoControl = new BancoControler();

        // Popula a base com um registro padrao
        public void PopularBase()
        {
            this.SalvarObjeto(new Secretaria()
            {
                Nome = "Administrador",
                Banco = bancoControl.getBanco("1"),
                DataNasc = DateTime.Now,
            });
        }

        // Salva ou atualiza um objeto
        public void SalvarObjeto(Secretaria objeto)
        {
            try
            {
                // marca os attributos que são objetos como já existentes evitando a duplicação
                ctx.Entry(objeto.Banco).State = System.Data.Entity.EntityState.Unchanged;

                if (objeto.Id == 0)
                {
                    ctx.Secretarias.Add(objeto);
                }
                else
                {
                    var tempObjeto = ctx.Secretarias.SingleOrDefault(temp => temp.Id == objeto.Id);
                    tempObjeto.Id = objeto.Id;
                    tempObjeto.Nome = objeto.Nome;
                    tempObjeto.Cpf = objeto.Cpf;
                    tempObjeto.DataNasc = objeto.DataNasc;
                    tempObjeto.Telefone = objeto.Telefone;
                    tempObjeto.Banco = objeto.Banco;
                }

                ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                Util.HandleSQLDBException(ex);
            }
        }

        // remove um objeto
        public void RemoverObjeto(Secretaria objeto)
        {
            if (objeto.Id != 0)
            {
                ctx.Secretarias.Remove(ctx.Secretarias.Single(temp => temp.Id == objeto.Id));
                ctx.SaveChanges();
            }
        }

        // lista todos os registros
        public IList<Secretaria> ObterObjetos()
        {
            var objetos = from objeto in ctx.Secretarias.Include("Banco") select objeto;
            return objetos.ToList();
        }

        // busca um registro especifico
        public Secretaria getObjeto(String StringId)
        {

            int id = int.Parse(StringId);
            var selectedObjeto = from objeto in ctx.Secretarias.Include("Banco")
                                 where objeto.Id == id
                                 select objeto;

            return selectedObjeto.ToList().ElementAt(0);
        }
    }
}
