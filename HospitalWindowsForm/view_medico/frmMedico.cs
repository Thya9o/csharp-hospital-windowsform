using HospitalModel;
using HospitalWindowsForm.view_medico;
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
    public partial class frmMedico : Form
    {
        public Medico medico;

        public frmMedico()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultaRealizada_Click(object sender, EventArgs e)
        {
            frmConsultas form = new frmConsultas();
            form.medico = medico;
            form.ShowDialog();
        }

        private void btnAgendamentos_Click(object sender, EventArgs e)
        {
            frmAgendamentos form = new frmAgendamentos();
            form.medico = medico;
            form.ShowDialog();
        }

        private void frmMedico_Load(object sender, EventArgs e)
        {

        }
    }
}
