namespace HospitalWindowsForm.view_admin
{
    partial class frmRealizarConsulta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dateData = new System.Windows.Forms.DateTimePicker();
            this.cbPaciente = new System.Windows.Forms.ComboBox();
            this.bsPaciente = new System.Windows.Forms.BindingSource(this.components);
            this.cbMedico = new System.Windows.Forms.ComboBox();
            this.bsMedico = new System.Windows.Forms.BindingSource(this.components);
            this.cbAgendamento = new System.Windows.Forms.ComboBox();
            this.bsAgendamento = new System.Windows.Forms.BindingSource(this.components);
            this.lbAgendamento = new System.Windows.Forms.Label();
            this.lbData = new System.Windows.Forms.Label();
            this.lbMedico = new System.Windows.Forms.Label();
            this.lbPaciente = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.MaskedTextBox();
            this.dateHorario = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsPaciente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMedico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAgendamento)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalvar.Location = new System.Drawing.Point(12, 179);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(120, 50);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(370, 179);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 50);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dateData
            // 
            this.dateData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateData.Location = new System.Drawing.Point(99, 69);
            this.dateData.Name = "dateData";
            this.dateData.Size = new System.Drawing.Size(145, 20);
            this.dateData.TabIndex = 18;
            // 
            // cbPaciente
            // 
            this.cbPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPaciente.DataSource = this.bsPaciente;
            this.cbPaciente.DisplayMember = "Nome";
            this.cbPaciente.FormattingEnabled = true;
            this.cbPaciente.Location = new System.Drawing.Point(99, 6);
            this.cbPaciente.Name = "cbPaciente";
            this.cbPaciente.Size = new System.Drawing.Size(391, 21);
            this.cbPaciente.TabIndex = 17;
            this.cbPaciente.ValueMember = "Id";
            // 
            // bsPaciente
            // 
            this.bsPaciente.DataSource = typeof(HospitalModel.Paciente);
            // 
            // cbMedico
            // 
            this.cbMedico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMedico.DataSource = this.bsMedico;
            this.cbMedico.DisplayMember = "Nome";
            this.cbMedico.FormattingEnabled = true;
            this.cbMedico.Location = new System.Drawing.Point(99, 37);
            this.cbMedico.Name = "cbMedico";
            this.cbMedico.Size = new System.Drawing.Size(391, 21);
            this.cbMedico.TabIndex = 16;
            this.cbMedico.ValueMember = "Id";
            this.cbMedico.SelectedIndexChanged += new System.EventHandler(this.cbMedico_SelectedIndexChanged);
            // 
            // bsMedico
            // 
            this.bsMedico.DataSource = typeof(HospitalModel.Medico);
            // 
            // cbAgendamento
            // 
            this.cbAgendamento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAgendamento.DataSource = this.bsAgendamento;
            this.cbAgendamento.DisplayMember = "getAgendamento";
            this.cbAgendamento.FormattingEnabled = true;
            this.cbAgendamento.Location = new System.Drawing.Point(332, 99);
            this.cbAgendamento.Name = "cbAgendamento";
            this.cbAgendamento.Size = new System.Drawing.Size(158, 21);
            this.cbAgendamento.TabIndex = 15;
            this.cbAgendamento.ValueMember = "Id";
            this.cbAgendamento.SelectedIndexChanged += new System.EventHandler(this.cbAgendamento_SelectedIndexChanged);
            // 
            // bsAgendamento
            // 
            this.bsAgendamento.DataSource = typeof(HospitalModel.Agendamento);
            // 
            // lbAgendamento
            // 
            this.lbAgendamento.AutoSize = true;
            this.lbAgendamento.Location = new System.Drawing.Point(250, 102);
            this.lbAgendamento.Name = "lbAgendamento";
            this.lbAgendamento.Size = new System.Drawing.Size(76, 13);
            this.lbAgendamento.TabIndex = 14;
            this.lbAgendamento.Text = "Agendamento:";
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Location = new System.Drawing.Point(12, 71);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(33, 13);
            this.lbData.TabIndex = 13;
            this.lbData.Text = "Data:";
            // 
            // lbMedico
            // 
            this.lbMedico.AutoSize = true;
            this.lbMedico.Location = new System.Drawing.Point(12, 40);
            this.lbMedico.Name = "lbMedico";
            this.lbMedico.Size = new System.Drawing.Size(45, 13);
            this.lbMedico.TabIndex = 12;
            this.lbMedico.Text = "Médico:";
            // 
            // lbPaciente
            // 
            this.lbPaciente.AutoSize = true;
            this.lbPaciente.Location = new System.Drawing.Point(12, 9);
            this.lbPaciente.Name = "lbPaciente";
            this.lbPaciente.Size = new System.Drawing.Size(52, 13);
            this.lbPaciente.TabIndex = 11;
            this.lbPaciente.Text = "Paciente:";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(12, 102);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(34, 13);
            this.lbTotal.TabIndex = 19;
            this.lbTotal.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(99, 99);
            this.txtTotal.Mask = "999.99";
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(145, 20);
            this.txtTotal.TabIndex = 20;
            this.txtTotal.Click += new System.EventHandler(this.txtTotal_Click_1);
            // 
            // dateHorario
            // 
            this.dateHorario.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateHorario.Location = new System.Drawing.Point(332, 69);
            this.dateHorario.Name = "dateHorario";
            this.dateHorario.ShowUpDown = true;
            this.dateHorario.Size = new System.Drawing.Size(158, 20);
            this.dateHorario.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Horário:";
            // 
            // frmRealizarConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 241);
            this.Controls.Add(this.dateHorario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.dateData);
            this.Controls.Add(this.cbPaciente);
            this.Controls.Add(this.cbMedico);
            this.Controls.Add(this.cbAgendamento);
            this.Controls.Add(this.lbAgendamento);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.lbMedico);
            this.Controls.Add(this.lbPaciente);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Name = "frmRealizarConsulta";
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.frmRealizarConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsPaciente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMedico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAgendamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker dateData;
        private System.Windows.Forms.ComboBox cbPaciente;
        private System.Windows.Forms.ComboBox cbMedico;
        private System.Windows.Forms.ComboBox cbAgendamento;
        private System.Windows.Forms.Label lbAgendamento;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Label lbMedico;
        private System.Windows.Forms.Label lbPaciente;
        private System.Windows.Forms.BindingSource bsPaciente;
        private System.Windows.Forms.BindingSource bsMedico;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.MaskedTextBox txtTotal;
        private System.Windows.Forms.DateTimePicker dateHorario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bsAgendamento;
    }
}