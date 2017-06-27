using HospitalLib.Controler;
using HospitalModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HospitalWindowsForm
{
    public partial class frmCadastrarAreaAtuacao : Form
    {
        public AreaAtuacao objeto { get; set; }
        public AreaAtuacaoControler control = new AreaAtuacaoControler();

        public frmCadastrarAreaAtuacao()
        {
            InitializeComponent();
            this.objeto = new AreaAtuacao();
        }
        private void frmCadastrarAreaAtuacao_Load(object sender, EventArgs e)
        {
            control = new AreaAtuacaoControler();

            if (objeto.Id > 0)
            {
                txtAreaAtuacao.Text = objeto.Area;
                mtValor.Text = objeto.Valor.ToString();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            try
            {
                // verifica se o campo de valor foi preenchido completamente
                if (mtValor.Text.Length < 6)
                {
                    throw new FormatException();
                }
                // exception se o crm nao for informado
                if (string.IsNullOrWhiteSpace(txtAreaAtuacao.Text))
                {
                    throw new ArgumentNullException("Por favor informe a área de atuação.");
                }

                this.objeto.Area = txtAreaAtuacao.Text;
                objeto.Valor = Decimal.Parse(mtValor.Text);
                control.SalvarObjeto(this.objeto);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.ParamName, "Erro Interno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("O Valor digitado não informado ou não é valido. Por favor verifique e preencha todo o campo.", "Valor Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível salvar. Tente novamente.", "Erro Interno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // seleciona todo o conteudo do input (focus)
        private void mtValor_Click(object sender, EventArgs e)
        {
            mtValor.SelectAll();
        }
    }
}
