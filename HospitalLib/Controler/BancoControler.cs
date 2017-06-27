using HospitalModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalLib.Controler
{
    public class BancoControler
    {
        public HospitalContext ctx = new HospitalContext();

        // Popula a base com um registro padrao
        public void PopularBase()
        {
            this.SalvarBanco(new Banco()
            {
                Nome = "Banco do Brasil",
                Conta = "16696-01",
                Agencia = "1669-0",
            });
        }

        // Salva ou atualiza um objeto
        public void SalvarBanco(Banco banco)
        {
            try
            {
                if (banco.Id == 0)
                {
                    ctx.Bancos.Add(banco);
                }
                else
                {
                    var tempBanco = ctx.Bancos.SingleOrDefault(b => b.Id == banco.Id);
                    tempBanco.Id = banco.Id;
                    tempBanco.Nome = banco.Nome;
                    tempBanco.Conta = banco.Conta;
                    tempBanco.Agencia = banco.Agencia;
                }

                ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                Util.HandleSQLDBException(ex);
            }
        }

        // remove um objeto
        public void RemoverBanco(Banco banco)
        {
            if (banco.Id != 0)
            {
                ctx.Bancos.Remove(ctx.Bancos.Single(b => b.Id == banco.Id));
                ctx.SaveChanges();
            }
        }

        // lista todos os registros
        public IList<Banco> ObterBancos()
        {
            var bancos = from banco in ctx.Bancos select banco;
            return bancos.ToList();
        }

        // busca um registro especifico
        public Banco getBanco(String StringId) {

            int id = int.Parse(StringId);
            var selectedBanco = from banco in ctx.Bancos
                                where banco.Id == id
                                select banco;

            return selectedBanco.ToList().ElementAt(0);
        }
    }
}
