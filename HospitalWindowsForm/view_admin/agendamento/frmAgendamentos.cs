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

namespace HospitalWindowsForm.view_admin.agendamento
{
    public partial class frmAgendamentos : Form
    {
        public frmAgendamentos()
        {
            InitializeComponent();
        }

        public AgendamentoControler control;
        private void frmAgendamentos_Load(object sender, EventArgs e)
        {
            control = new AgendamentoControler();
            this.binding();
        }

        private void binding()
        {
            bsAgendamento.DataSource = control.ObterObjetos();
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            frmAgendarConsulta form = new frmAgendarConsulta();
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.binding();
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            frmAgendarConsulta form = new frmAgendarConsulta();
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.binding();
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            frmAgendarConsulta form = new frmAgendarConsulta();
            form.objeto = (Agendamento)bsAgendamento.Current;

            if (form.ShowDialog() == DialogResult.OK)
            {
                this.binding();
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            Agendamento agendamento = (Agendamento)bsAgendamento.Current;

            if (agendamento != null) {

                try
                {
                    // verifica se o registro é algum default que não pode ser deletado
                    if (agendamento.Id == 1) {
                        throw new ArgumentException("Não é possível excluir esse registro padrão.");
                    }

                    control.RemoverObjeto((Agendamento)bsAgendamento.Current);

                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, "Erro Interno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show("Não é possível deletar o Registro. Há outros dados vinculados a ele.", "Erro Interno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível deletar o registro. Tente novamente.", "Erro Interno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            this.binding();   
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
