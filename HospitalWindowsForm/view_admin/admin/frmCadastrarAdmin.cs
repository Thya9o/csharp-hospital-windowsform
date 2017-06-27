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
    public partial class frmCadastrarAdmin : Form
    {
        public Secretaria objeto { get; set; }
        public SecretariaControler control = new SecretariaControler();
        public BancoControler bancoControl = new BancoControler();
        
        public frmCadastrarAdmin()
        {
            InitializeComponent();
            objeto = new Secretaria();
        }

        private void frmCadastrarAdmin_Load(object sender, EventArgs e)
        {
            control = new SecretariaControler();
            
            bsBancos.DataSource = bancoControl.ObterBancos();

            if (objeto.Id > 0) {
                txtNome.Text = objeto.Nome;
                txtCpf.Text = objeto.Cpf;
                dateNasc.Value = objeto.DataNasc;
                txtTelefone.Text = objeto.Telefone;
                cbBanco.SelectedValue = objeto.Banco.Id;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            try
            {
                // execption se o nome nao for informado
                if (string.IsNullOrWhiteSpace(txtNome.Text))
                {
                    throw new ArgumentNullException("Por favor informe o nome do administrador.");
                }
                // exception se o cpf nao for informado
                if (string.IsNullOrWhiteSpace(txtCpf.Text))
                {
                    throw new ArgumentNullException("Por favor um CPF para o administrador.");
                }

                objeto.Nome = txtNome.Text;
                objeto.Cpf = txtCpf.Text;
                objeto.DataNasc = dateNasc.Value.Date;
                objeto.Telefone = txtTelefone.Text;
                objeto.Banco = bancoControl.getBanco(cbBanco.SelectedValue.ToString());
                
                control.SalvarObjeto(objeto);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.ParamName, "Erro Interno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível salvar. Tente novamente.", "Erro Interno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
