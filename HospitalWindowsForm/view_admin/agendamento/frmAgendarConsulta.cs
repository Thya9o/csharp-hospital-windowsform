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
    public partial class frmAgendarConsulta : Form
    {
        public Agendamento objeto { get; set; }

        // variaveis de controle
        public AgendamentoControler control = new AgendamentoControler();
        public PacienteControler pacienteControl = new PacienteControler();
        public MedicoControler medicoControl = new MedicoControler();
        public SecretariaControler adminControl = new SecretariaControler();

        // variaveis para fazer as validações de data
        public DateTime dateNow = DateTime.Now;
        public DateTime turno_inicio;
        public DateTime turno_fim;

        public frmAgendarConsulta()
        {
            InitializeComponent();
            objeto = new Agendamento();
        }

        private void frmAgendarConsulta_Load(object sender, EventArgs e)
        {
            control = new AgendamentoControler();

            bsPaciente.DataSource = pacienteControl.ObterObjetos();
            bsMedico.DataSource = medicoControl.ObterMedicos();
            bsSecretaria.DataSource = adminControl.ObterObjetos();

            // seta o turno do medico ja selecionado por default
            txtTurno.Text = ((Medico)cbMedico.SelectedItem).Turno;

            if (objeto.Id > 0)
            {
                cbPaciente.SelectedValue = objeto.Paciente.Id;
                cbMedico.SelectedValue = objeto.Medico.Id;
                cbAdmin.SelectedValue = objeto.Secretaria.Id;
                dateData.Value = objeto.DataAgendada;
                dateHorario.Value = objeto.DataAgendada; ;
                txtTurno.Text = objeto.Medico.Turno;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                // verifica o turno do medico e compara com a data e horarios agendados
                switch (((Medico)cbMedico.SelectedItem).Turno) {
                    case "Diruno":

                        turno_inicio = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day, 8, 0, 0);
                        turno_fim = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day, 16, 0, 0);
                        if (dateHorario.Value.TimeOfDay < turno_inicio.TimeOfDay || dateHorario.Value.TimeOfDay > turno_fim.TimeOfDay) {
                            throw new ArgumentException("O horário agendado não é compatível com o turno do médico.");
                        }

                        break;
                    case "Noturno":

                        turno_inicio = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day, 16, 0, 01);
                        turno_fim = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day, 23, 59, 59);
                        if (dateHorario.Value.TimeOfDay < turno_inicio.TimeOfDay || dateHorario.Value.TimeOfDay > turno_fim.TimeOfDay)
                        {
                            throw new ArgumentException("O horário agendado não é compatível com o turno do médico.");
                        }

                        break;
                    case "Madrugada":

                        turno_inicio = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day, 0, 0, 0);
                        turno_fim = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day, 07, 59, 59);
                        if (dateHorario.Value.TimeOfDay < turno_inicio.TimeOfDay || dateHorario.Value.TimeOfDay > turno_fim.TimeOfDay)
                        {
                            throw new ArgumentException("O horário agendado não é compatível com o turno do médico.");
                        }

                        break;
                }

                // verifica se a data agendada é um dia de final de semana (sábado ou domingo)
                if ((dateData.Value.DayOfWeek == DayOfWeek.Saturday) || (dateData.Value.DayOfWeek == DayOfWeek.Sunday)) {
                    throw new ArgumentException("Não é possível agendar consultas para Sábado ou Domingo.");
                }

                // busca os objetos pelo id (indice) selecionado nos combo box
                objeto.Paciente = (Paciente)cbPaciente.SelectedItem;
                objeto.Medico = (Medico)cbMedico.SelectedItem;
                objeto.Secretaria = (Secretaria)cbAdmin.SelectedItem;

                // monta a data do agendamento juntando a data e o horario
                objeto.DataAgendada = dateData.Value.Date + dateHorario.Value.TimeOfDay;

                control.SalvarObjeto(objeto);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Erro Interno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void cbMedico_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTurno.Text = ((Medico)cbMedico.SelectedItem).Turno;
        }
    }
}
