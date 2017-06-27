using HospitalLib.Controler;
using HospitalModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalWindowsForm.view_admin
{
    public partial class frmConsultarBanco : Form
    {
        public frmConsultarBanco()
        {
            InitializeComponent();
        }

        public BancoControler bancoControl = new BancoControler();

        private void frmConsultarBanco_Load(object sender, EventArgs e)
        {
            bancoControl = new BancoControler();
            this.binding();
        }

        private void binding()
        {
            bsBancos.DataSource = bancoControl.ObterBancos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrarBanco_Click(object sender, EventArgs e)
        {
            frmCadastrarBanco form = new frmCadastrarBanco();
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.binding();
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            frmCadastrarBanco form = new frmCadastrarBanco();
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.binding();
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            Banco banco = (Banco)bsBancos.Current;

            if (banco != null)
            {
                try {

                    // verifica se o registro é algum default que não pode ser deletado
                    if (banco.Id == 1) {
                        throw new ArgumentException("Não é possível excluir esse registro padrão.");
                    }

                    this.bancoControl.RemoverBanco(banco);

                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, "Erro Interno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (DbUpdateException ex) {
                    MessageBox.Show("Não é possível deletar o Banco. Há outros dados vinculados a ele.", "Erro Interno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível deletar o registro. Tente novamente.", "Erro Interno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            this.binding();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            frmCadastrarBanco form = new frmCadastrarBanco();
            form.Banco = (Banco)bsBancos.Current;

            if (form.ShowDialog() == DialogResult.OK)
            {
                this.binding();
            }
        }
    }
}
