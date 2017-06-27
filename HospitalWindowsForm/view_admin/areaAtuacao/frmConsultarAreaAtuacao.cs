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
    public partial class frmConsultarAreaAtuacao : Form
    {
        public frmConsultarAreaAtuacao()
        {
            InitializeComponent();
        }

        public AreaAtuacaoControler control;
        private void frmConsultarAreaAtuacao_Load(object sender, EventArgs e)
        {
            control = new AreaAtuacaoControler();
            this.binding();
        }

        private void binding()
        {
            bsAreaAtuacao.DataSource = control.ObterObjetos();
        }

        private void btnCadastrarAreaAtuacao_Click(object sender, EventArgs e)
        {
            frmCadastrarAreaAtuacao form = new frmCadastrarAreaAtuacao();
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.binding();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            frmCadastrarAreaAtuacao form = new frmCadastrarAreaAtuacao();
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.binding();
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            AreaAtuacao area = (AreaAtuacao)bsAreaAtuacao.Current;

            if (area != null)
            {
                try {

                    // verifica se o registro é algum default que não pode ser deletado
                    if (area.Id == 1 || area.Id == 2 || area.Id == 3)
                    {
                        throw new ArgumentException("Não é possível excluir esse registro padrão.");
                    }

                    control.RemoverObjeto(area);
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, "Erro Interno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show("Não é possível deletar o registro. Há outros dados vinculados a ele.", "Erro Interno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            frmCadastrarAreaAtuacao form = new frmCadastrarAreaAtuacao();
            form.objeto = (AreaAtuacao)bsAreaAtuacao.Current;

            if (form.ShowDialog() == DialogResult.OK)
            {
                this.binding();
            }
        }
    }
}
