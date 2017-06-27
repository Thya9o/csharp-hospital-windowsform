using HospitalModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalLib.Controler
{
    public class ConvenioControler
    {
        public HospitalContext ctx = new HospitalContext();

        // Popula a base com um registro padrao
        public void PopularBase()
        {
            this.SalvarObjeto(new Convenio()
            {
                NomePlano = "Sem Convênio",
                NomeEmpresa = "Sem Empresa",
                Telefone = "",
            });
        }

        // Salva ou atualiza um objeto
        public void SalvarObjeto(Convenio objeto)
        {
            try
            {
                if (objeto.Id == 0)
                {
                    ctx.Convenios.Add(objeto);
                }
                else
                {
                    var tempObjeto = ctx.Convenios.SingleOrDefault(temp => temp.Id == objeto.Id);
                    tempObjeto.Id = objeto.Id;
                    tempObjeto.NomePlano = objeto.NomePlano;
                    tempObjeto.NomeEmpresa = objeto.NomeEmpresa;
                    tempObjeto.Telefone = objeto.Telefone;
                }

                ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                Util.HandleSQLDBException(ex);
            }
        }

        // remove um objeto
        public void RemoverObjeto(Convenio objeto)
        {
            if (objeto.Id != 0)
            {
                ctx.Convenios.Remove(ctx.Convenios.Single(temp => temp.Id == objeto.Id));
                ctx.SaveChanges();
            }
        }

        // lista todos os registros
        public IList<Convenio> ObterObjetos()
        {
            var objetos = from objeto in ctx.Convenios select objeto;
            return objetos.ToList();
        }

        // busca um registro especifico
        public Convenio getObjeto(String StringId)
        {

            int id = int.Parse(StringId);
            var selectedObjeto = from objeto in ctx.Convenios
                                 where objeto.Id == id
                                 select objeto;

            return selectedObjeto.ToList().ElementAt(0);
        }
    }
}
