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
    public partial class frmRealizarConsulta : Form
    {
        public Consulta objeto { get; set; }
        public Agendamento consulta_agendada = new Agendamento();

        // variaveis de controle
        public ConsultaControler control = new ConsultaControler();
        public PacienteControler pacienteControl = new PacienteControler();
        public MedicoControler medicoControl = new MedicoControler();
        public AgendamentoControler agendamentoControl = new AgendamentoControler();
        public AreaAtuacaoControler atuacaoControl = new AreaAtuacaoControler();

        public frmRealizarConsulta()
        {
            InitializeComponent();
            objeto = new Consulta();
        }

        private void frmRealizarConsulta_Load(object sender, EventArgs e)
        {
            control = new ConsultaControler();
           
            // alimenta os combobox
            bsPaciente.DataSource = pacienteControl.ObterObjetos();
            bsMedico.DataSource = medicoControl.ObterMedicos();
            bsAgendamento.DataSource = agendamentoControl.ObterObjetos();

            // seta o valor inicial da consulta
            txtTotal.Text = atuacaoControl.getValor(((Medico)cbMedico.SelectedItem).AreaAtuacao.Id, false);

            if (objeto.Id > 0)
            {
                cbPaciente.SelectedIndex = objeto.Paciente.Id;
                cbMedico.SelectedIndex = objeto.Medico.Id;
                dateData.Value = objeto.Data;
                dateHorario.Value = objeto.Data;
                txtTotal.Text = objeto.PrecoTotal.ToString();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                // verifica se o campo de valor foi preenchido completamente
                if (txtTotal.Text.Length < 6)
                {
                    throw new FormatException();
                }

                // busca os objetos pelo id (indice) selecionado nos combo box
                objeto.Paciente = pacienteControl.getObjeto(cbPaciente.SelectedValue.ToString());
                objeto.Medico = medicoControl.getMedico(cbMedico.SelectedValue.ToString());
                objeto.Agendamento = agendamentoControl.getObjeto(cbAgendamento.SelectedValue.ToString());

                // formata o do input para decimal
                objeto.PrecoTotal = Decimal.Parse(txtTotal.Text);
                // monta a data da consulta com a data e com o horario
                objeto.Data = dateData.Value.Date + dateHorario.Value.TimeOfDay;

                control.SalvarObjeto(objeto);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("O Valor digitado não informado ou não é valido. Por favor veifique e preencha todo o campo.", "Valor Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void txtTotal_Click_1(object sender, EventArgs e)
        {
            txtTotal.SelectAll();
        }

        // carrega os dados do agendamento na consulta quando o agendamento e trocado
        private void cbAgendamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAgendamento.SelectedIndex != 0)
            {

                consulta_agendada = agendamentoControl.getObjeto(cbAgendamento.SelectedValue.ToString());

                // seta os dados do agendamento
                cbPaciente.SelectedValue = consulta_agendada.Paciente.Id;
                cbMedico.SelectedValue = consulta_agendada.Medico.Id;
                dateData.Value = consulta_agendada.DataAgendada;
                dateHorario.Value = consulta_agendada.DataAgendada;

                // seta o valor de uma consulta agendada com o médico
                txtTotal.Text = atuacaoControl.getValor(consulta_agendada.Medico.AreaAtuacao.Id, true);

            }
            else {

                // seta o valor de uma consulta não agendada com o médico
                txtTotal.Text = atuacaoControl.getValor(((Medico)cbMedico.SelectedItem).AreaAtuacao.Id, false);

            }
        }

        private void cbMedico_SelectedIndexChanged(object sender, EventArgs e)
        {
             //seta o valor da consulta com base na area de atuacao do medico
             txtTotal.Text = atuacaoControl.getValor(((Medico)cbMedico.SelectedItem).AreaAtuacao.Id, false);
        }    
    }
}
