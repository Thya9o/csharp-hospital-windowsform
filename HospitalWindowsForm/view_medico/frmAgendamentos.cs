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
    public partial class frmAgendamentos : Form
    {
        public frmAgendamentos()
        {
            InitializeComponent();
        }

        public AgendamentoControler control;
        public Medico medico;
        private void frmAgendamentos_Load(object sender, EventArgs e)
        {
            control = new AgendamentoControler();
            this.binding();
        }

        private void binding()
        {
            bsAgendamentos.DataSource = control.getAgendamentos(medico);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
