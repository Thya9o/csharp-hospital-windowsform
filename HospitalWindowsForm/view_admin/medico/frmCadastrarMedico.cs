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
using System.Data.SqlClient;
using System.Data.Entity.Validation;

namespace HospitalWindowsForm.view_admin
{
    public partial class frmCadastrarMedico : Form
    {
        public Medico Medico { get; set; }
        public MedicoControler medicoControl = new MedicoControler();
        public BancoControler bancoControl = new BancoControler();
        public AreaAtuacaoControler areaAtuacaoControl = new AreaAtuacaoControler();

        public frmCadastrarMedico()
        {
            InitializeComponent();
            this.Medico = new Medico();
        }

        private void frmCadastrarMedico_Load(object sender, EventArgs e)
        {
            medicoControl = new MedicoControler();

            bsBancos.DataSource = bancoControl.ObterBancos();
            bsAreaAtuacao.DataSource = areaAtuacaoControl.ObterObjetos();
                
            if (Medico.Id > 0) {
                txtNome.Text = Medico.Nome;
                txtCpf.Text = Medico.Cpf;
                txtCrm.Text = Medico.Crm;
                dateNasc.Value = Medico.DataNasc;
                cbTurno.Text = Medico.Turno;
                txtTelefone.Text = Medico.Telefone;
                cbBanco.SelectedValue = Medico.Banco.Id;
                cbAreaAtuacao.SelectedValue = Medico.AreaAtuacao.Id;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                // execption se o nome nao for informado
                if (string.IsNullOrWhiteSpace(txtNome.Text))
                {
                    throw new ArgumentNullException("Por favor informe o nome do médico.");
                }
                // exception se o cpf nao for informado
                if (string.IsNullOrWhiteSpace(txtCpf.Text))
                {
                    throw new ArgumentNullException("Por favor informe um CPF para o médico.");
                }
                // exception se o crm nao for informado
                if (string.IsNullOrWhiteSpace(txtCrm.Text))
                {
                    throw new ArgumentNullException("Por favor informe um CRM para o médico.");
                }
                // exception se o turno nao for informado
                if (cbTurno.SelectedItem == null) {
                    throw new ArgumentNullException("Por favor selecione um turno para o médico.");
                }

                Medico.Nome = txtNome.Text;
                Medico.Cpf = txtCpf.Text;
                Medico.Crm = txtCrm.Text;
                Medico.DataNasc = dateNasc.Value;
                Medico.Turno = cbTurno.Text;
                Medico.Telefone = txtTelefone.Text;
                Medico.Banco = bancoControl.getBanco(cbBanco.SelectedValue.ToString());
                Medico.AreaAtuacao = areaAtuacaoControl.getObjeto(cbAreaAtuacao.SelectedValue.ToString());

                medicoControl.SalvarMedico(Medico);

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
