using HospitalModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalLib.Controler
{
    public class AreaAtuacaoControler
    {
        public HospitalContext ctx = new HospitalContext();

        // Popula a base com alguns registros padroes
        public void PopularBase()
        {
            this.SalvarObjeto(new AreaAtuacao()
            {
                Area = "Ortopedia",
                Valor = 300.00M,
            });
            this.SalvarObjeto(new AreaAtuacao()
            {
                Area = "Psiquiatria",
                Valor = 250.00M,
            });
            this.SalvarObjeto(new AreaAtuacao()
            {
                Area = "Pediatria",
                Valor = 200.00M,
            });
        }

        // Salva ou atualiza um objeto
        public void SalvarObjeto(AreaAtuacao objeto)
        {
            try
            {
                if (objeto.Id == 0)
                {
                    ctx.AreasAtuacao.Add(objeto);
                }
                else
                {
                    var tempObjeto = ctx.AreasAtuacao.SingleOrDefault(temp => temp.Id == objeto.Id);
                    tempObjeto.Id = objeto.Id;
                    tempObjeto.Area = objeto.Area;
                    tempObjeto.Valor = objeto.Valor;
                }

                ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                Util.HandleSQLDBException(ex);
            }
        }

        // remove um objeto
        public void RemoverObjeto(AreaAtuacao objeto)
        {
            if (objeto.Id != 0)
            {
                ctx.AreasAtuacao.Remove(ctx.AreasAtuacao.Single(temp => temp.Id == objeto.Id));
                ctx.SaveChanges();
            }
        }

        // lista todos os registros
        public IList<AreaAtuacao> ObterObjetos()
        {
            var objetos = from objeto in ctx.AreasAtuacao select objeto;
            return objetos.ToList();
        }

        // busca um registro especifico
        public AreaAtuacao getObjeto(String StringId)
        {

            int id = int.Parse(StringId);
            var selectedObjeto = from objeto in ctx.AreasAtuacao
                                where objeto.Id == id
                                select objeto;

            return selectedObjeto.ToList().ElementAt(0);
        }

        // busca o valor de uma area de atuacao especifica
        public String getValor(int id, Boolean agendado = false)
        {
            Decimal valor;
            var selectedObjeto = from objeto in ctx.AreasAtuacao
                                 where objeto.Id == id
                                 select objeto;

            valor = selectedObjeto.ToList().ElementAt(0).Valor;

            // se a consulta possuir um agendamento e concedido um desconto de 10%
            if (agendado == true) {
                valor = valor - ((valor / 100) * 10);
            }

            return valor.ToString();
        }
    }
}
