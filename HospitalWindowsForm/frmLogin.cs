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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnMedico_Click(object sender, EventArgs e)
        {
            frmMedicoLogin form = new frmMedicoLogin();
            form.ShowDialog();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            frmAdmin form = new frmAdmin();
            form.ShowDialog();
        }
    }
}
