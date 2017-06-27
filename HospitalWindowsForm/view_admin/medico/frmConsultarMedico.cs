using HospitalLib.Controler;
using HospitalModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Entity.Infrastructure;

namespace HospitalWindowsForm.view_admin
{
    public partial class frmConsultarMedico : Form
    {
        public frmConsultarMedico()
        {
            InitializeComponent();
        }

        public MedicoControler medicoControl = new MedicoControler();

        private void frmConsultarMedico_Load(object sender, EventArgs e)
        {
            medicoControl = new MedicoControler();
            this.binding();
        }

        private void binding()
        {
            bsMedico.DataSource = medicoControl.ObterMedicos();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            frmCadastrarMedico form = new frmCadastrarMedico();
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.binding();
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            Medico medico = (Medico)bsMedico.Current;

            if (medico != null)
            {
                try {

                    // verifica se o registro é algum default que não pode ser deletado
                    if (medico.Id == 1) {
                        throw new ArgumentException("Não é possível excluir esse registro padrão.");
                    }

                    this.medicoControl.RemoverMedico(medico);
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, "Erro Interno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show("Não é possível deletar o Médico. Há outros dados vinculados a ele.", "Erro Interno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnNovoMedico_Click(object sender, EventArgs e)
        {
            frmCadastrarMedico form = new frmCadastrarMedico();
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.binding();
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            frmCadastrarMedico form = new frmCadastrarMedico();
            form.Medico = (Medico)bsMedico.Current;

            if (form.ShowDialog() == DialogResult.OK)
            {
                this.binding();
            }
        }
    }
}
