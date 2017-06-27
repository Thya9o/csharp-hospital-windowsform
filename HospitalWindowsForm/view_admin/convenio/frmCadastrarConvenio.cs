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

namespace HospitalWindowsForm.view_admin
{
    public partial class frmCadastrarConvenio : Form
    {

        public Convenio objeto { get; set; }
        public ConvenioControler control = new ConvenioControler();

        public frmCadastrarConvenio()
        {
            InitializeComponent();
            this.objeto = new Convenio();
        }

        private void frmCadastrarConvenio_Load(object sender, EventArgs e)
        {
            control = new ConvenioControler();

            if (objeto.Id > 0) {
                txtPlano.Text = objeto.NomePlano;
                txtEmpresa.Text = objeto.NomeEmpresa;
                txtTelefone.Text = objeto.Telefone;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                // exception se o plano nao for informado
                if (string.IsNullOrWhiteSpace(txtPlano.Text))
                {
                    throw new ArgumentNullException("Por favor informe o nome do plano do convênio.");
                }
                // exception se a empresa nao for informada
                if (string.IsNullOrWhiteSpace(txtEmpresa.Text))
                {
                    throw new ArgumentNullException("Por favor informe o nome da empresa do convênio.");
                }

                objeto.NomePlano = txtPlano.Text;
                objeto.NomeEmpresa = txtEmpresa.Text;
                objeto.Telefone = txtTelefone.Text;

                control.SalvarObjeto(objeto);
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.ParamName, "Erro Interno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível salvar. Tente novamente.", "Erro Interno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
