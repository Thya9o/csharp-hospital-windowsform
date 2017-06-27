using HospitalWindowsForm.view_admin;
using HospitalWindowsForm.view_admin.agendamento;
using HospitalWindowsForm.view_admin.consulta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalWindowsForm
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultarMedico_Click(object sender, EventArgs e)
        {
            frmConsultarMedico form = new frmConsultarMedico();
            form.ShowDialog();
        }

        private void btnConsultarAdmin_Click(object sender, EventArgs e)
        {
            frmConsultarAdmin form = new frmConsultarAdmin();
            form.ShowDialog();
        }

        private void btnConsultarPacientes_Click(object sender, EventArgs e)
        {
            frmConsultarPaciente form = new frmConsultarPaciente();
            form.ShowDialog();
        }

        private void btnAgendarConsulta_Click(object sender, EventArgs e)
        {
            frmAgendamentos form = new frmAgendamentos();
            form.ShowDialog();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            frmConsultas form = new frmConsultas();
            form.ShowDialog();
        }

        private void btnConsultarBanco_Click(object sender, EventArgs e)
        {
            frmConsultarBanco form = new frmConsultarBanco();
            form.ShowDialog();
        }

        private void btnConsultarAreaAtuacao_Click(object sender, EventArgs e)
        {
            frmConsultarAreaAtuacao form = new frmConsultarAreaAtuacao();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmConsultarConvenio form = new frmConsultarConvenio();
            form.ShowDialog();
        }
    }
}
