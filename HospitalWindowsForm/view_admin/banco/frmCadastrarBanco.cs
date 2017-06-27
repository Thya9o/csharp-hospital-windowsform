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
    public partial class frmCadastrarBanco : Form
    {

        public Banco Banco { get; set; }
        public BancoControler bancoControl = new BancoControler();

        public frmCadastrarBanco()
        {
            InitializeComponent();
            this.Banco = new Banco();
        }

        private void frmCadastrarBanco_Load(object sender, EventArgs e)
        {
            bancoControl = new BancoControler();

            if (Banco.Id > 0) {
                txtNome.Text = Banco.Nome;
                txtConta.Text = Banco.Conta;
                txtAgencia.Text = Banco.Agencia;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                // exception se o nome do banco nao for informado
                if (string.IsNullOrWhiteSpace(txtNome.Text))
                {
                    throw new ArgumentNullException("Por favor informe um  Nome para o banco.");
                }
                // exception se o conta nao for informado
                if (string.IsNullOrWhiteSpace(txtConta.Text))
                {
                    throw new ArgumentNullException("Por favor informe uma conta para o banco.");
                }
                // exception se o agencia nao for informado
                if (string.IsNullOrWhiteSpace(txtAgencia.Text))
                {
                    throw new ArgumentNullException("Por favor informe uma agência para o banco");
                }

                Banco.Nome = txtNome.Text;
                Banco.Conta = txtConta.Text;
                Banco.Agencia = txtAgencia.Text;

                bancoControl.SalvarBanco(Banco);
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
    }
}
