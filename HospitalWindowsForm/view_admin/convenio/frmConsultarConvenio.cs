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
    public partial class frmConsultarConvenio : Form
    {
        public frmConsultarConvenio()
        {
            InitializeComponent();
        }

        public ConvenioControler control = new ConvenioControler();

        private void frmConsultarConvenio_Load_1(object sender, EventArgs e)
        {
            control = new ConvenioControler();
            this.binding();
        }

        private void binding()
        {
            bsConvenio.DataSource = control.ObterObjetos();
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrarConvenio_Click(object sender, EventArgs e)
        {
            frmCadastrarConvenio form = new frmCadastrarConvenio();
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.binding();
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            frmCadastrarConvenio form = new frmCadastrarConvenio();
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.binding();
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            Convenio convenio = (Convenio)bsConvenio.Current;
            
            if (convenio != null)
            {
                try
                {
                    // verifica se o registro é algum default que não pode ser deletado
                    if (convenio.Id == 1)
                    {
                       throw new ArgumentException("Não é possível excluir esse registro padrão.");
                    }

                    control.RemoverObjeto(convenio);

                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, "Erro Interno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show("Não é possível deletar o Convênio. Há outros dados vinculados a ele.", "Erro Interno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível deletar o registro. Tente novamente.", "Erro Interno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else {
                MessageBox.Show("Não entrei");
            }

            this.binding();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            frmCadastrarConvenio form = new frmCadastrarConvenio();
            form.objeto = (Convenio)bsConvenio.Current;

            if (form.ShowDialog() == DialogResult.OK)
            {
                this.binding();
            }
        }
    }
}
