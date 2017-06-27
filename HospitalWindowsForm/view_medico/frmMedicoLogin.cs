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

namespace HospitalWindowsForm.view_medico
{
    public partial class frmMedicoLogin : Form
    {
        public frmMedicoLogin()
        {
            InitializeComponent();
        }

        public MedicoControler control = new MedicoControler();
        private void frmMedicoLogin_Load(object sender, EventArgs e)
        {
            bsMedicos.DataSource = control.ObterMedicos();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbMedicos.SelectedItem == null) {
                    throw new ArgumentException("Por favor selecione um médico para efetuar o login.");
                }

                frmMedico form = new frmMedico();
                form.medico = control.getMedico(cbMedicos.SelectedValue.ToString());
                form.ShowDialog();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Erro Interno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi posssivel logar. Por favor tente novamente.", "Erro Interno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
