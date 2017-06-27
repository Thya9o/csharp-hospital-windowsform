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
    public partial class frmConsultarAdmin : Form
    {
        public frmConsultarAdmin()
        {
            InitializeComponent();
        }

        public SecretariaControler control;
        private void frmConsultarAdmin_Load(object sender, EventArgs e)
        {
            control = new SecretariaControler();
            this.binding();
        }

        private void binding()
        {
            bsAdmin.DataSource = control.ObterObjetos();
        }

        private void btnCadastrarAdministrador_Click(object sender, EventArgs e)
        {
            frmCadastrarAdmin form = new frmCadastrarAdmin();
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.binding();
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            frmCadastrarAdmin form = new frmCadastrarAdmin();
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.binding();
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            Secretaria admin = (Secretaria)bsAdmin.Current;

            if (admin != null)
            {
                try {

                    // verifica se o registro é algum default que não pode ser deletado
                    if (admin.Id == 1) {
                        throw new ArgumentException("Não é possível excluir esse registro padrão.");
                    }

                    control.RemoverObjeto(admin);
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, "Erro Interno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show("Não é possível deletar o Administrador. Há outros dados vinculados a ele.", "Erro Interno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível deletar o registro. Tente novamente.", "Erro Interno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                this.binding();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            frmCadastrarAdmin form = new frmCadastrarAdmin();
            form.objeto = (Secretaria)bsAdmin.Current;

            if (form.ShowDialog() == DialogResult.OK)
            {
                this.binding();
            }
        }
    }
}
