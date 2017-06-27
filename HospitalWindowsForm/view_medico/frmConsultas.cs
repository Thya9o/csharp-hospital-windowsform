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
    public partial class frmConsultas : Form
    {
        public frmConsultas()
        {
            InitializeComponent();
        }

        public ConsultaControler control;
        public Medico medico;
        private void frmConsultas_Load(object sender, EventArgs e)
        {
            control = new ConsultaControler();
            this.binding();
        }

        private void binding()
        {
            bsConsultas.DataSource = control.getConsultas(medico);
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
