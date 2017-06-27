namespace HospitalWindowsForm.view_admin
{
    partial class frmAgendarConsulta
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
            this.lbPaciente = new System.Windows.Forms.Label();
            this.lbMedico = new System.Windows.Forms.Label();
            this.lbData = new System.Windows.Forms.Label();
            this.lbAdmin = new System.Windows.Forms.Label();
            this.cbAdmin = new System.Windows.Forms.ComboBox();
            this.bsSecretaria = new System.Windows.Forms.BindingSource(this.components);
            this.cbMedico = new System.Windows.Forms.ComboBox();
            this.bsMedico = new System.Windows.Forms.BindingSource(this.components);
            this.cbPaciente = new System.Windows.Forms.ComboBox();
            this.bsPaciente = new System.Windows.Forms.BindingSource(this.components);
            this.dateData = new System.Windows.Forms.DateTimePicker();
            this.lbTurno = new System.Windows.Forms.Label();
            this.txtTurno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateHorario = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.bsSecretaria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMedico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalvar.Location = new System.Drawing.Point(12, 198);
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
            this.btnCancelar.Location = new System.Drawing.Point(412, 198);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 50);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lbPaciente
            // 
            this.lbPaciente.AutoSize = true;
            this.lbPaciente.Location = new System.Drawing.Point(12, 41);
            this.lbPaciente.Name = "lbPaciente";
            this.lbPaciente.Size = new System.Drawing.Size(52, 13);
            this.lbPaciente.TabIndex = 2;
            this.lbPaciente.Text = "Paciente:";
            // 
            // lbMedico
            // 
            this.lbMedico.AutoSize = true;
            this.lbMedico.Location = new System.Drawing.Point(12, 75);
            this.lbMedico.Name = "lbMedico";
            this.lbMedico.Size = new System.Drawing.Size(45, 13);
            this.lbMedico.TabIndex = 3;
            this.lbMedico.Text = "Médico:";
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Location = new System.Drawing.Point(12, 109);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(33, 13);
            this.lbData.TabIndex = 4;
            this.lbData.Text = "Data:";
            // 
            // lbAdmin
            // 
            this.lbAdmin.AutoSize = true;
            this.lbAdmin.Location = new System.Drawing.Point(9, 143);
            this.lbAdmin.Name = "lbAdmin";
            this.lbAdmin.Size = new System.Drawing.Size(73, 13);
            this.lbAdmin.TabIndex = 5;
            this.lbAdmin.Text = "Administrador:";
            // 
            // cbAdmin
            // 
            this.cbAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAdmin.DataSource = this.bsSecretaria;
            this.cbAdmin.DisplayMember = "Nome";
            this.cbAdmin.FormattingEnabled = true;
            this.cbAdmin.Location = new System.Drawing.Point(88, 140);
            this.cbAdmin.Name = "cbAdmin";
            this.cbAdmin.Size = new System.Drawing.Size(444, 21);
            this.cbAdmin.TabIndex = 6;
            this.cbAdmin.ValueMember = "Id";
            // 
            // bsSecretaria
            // 
            this.bsSecretaria.DataSource = typeof(HospitalModel.Secretaria);
            // 
            // cbMedico
            // 
            this.cbMedico.DataSource = this.bsMedico;
            this.cbMedico.DisplayMember = "Nome";
            this.cbMedico.FormattingEnabled = true;
            this.cbMedico.Location = new System.Drawing.Point(88, 72);
            this.cbMedico.Name = "cbMedico";
            this.cbMedico.Size = new System.Drawing.Size(203, 21);
            this.cbMedico.TabIndex = 8;
            this.cbMedico.ValueMember = "Id";
            this.cbMedico.SelectedIndexChanged += new System.EventHandler(this.cbMedico_SelectedIndexChanged);
            // 
            // bsMedico
            // 
            this.bsMedico.DataSource = typeof(HospitalModel.Medico);
            // 
            // cbPaciente
            // 
            this.cbPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPaciente.DataSource = this.bsPaciente;
            this.cbPaciente.DisplayMember = "Nome";
            this.cbPaciente.FormattingEnabled = true;
            this.cbPaciente.Location = new System.Drawing.Point(88, 38);
            this.cbPaciente.Name = "cbPaciente";
            this.cbPaciente.Size = new System.Drawing.Size(444, 21);
            this.cbPaciente.TabIndex = 9;
            this.cbPaciente.ValueMember = "Id";
            // 
            // bsPaciente
            // 
            this.bsPaciente.DataSource = typeof(HospitalModel.Paciente);
            // 
            // dateData
            // 
            this.dateData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateData.Location = new System.Drawing.Point(88, 103);
            this.dateData.Name = "dateData";
            this.dateData.Size = new System.Drawing.Size(203, 20);
            this.dateData.TabIndex = 10;
            // 
            // lbTurno
            // 
            this.lbTurno.AutoSize = true;
            this.lbTurno.Location = new System.Drawing.Point(297, 76);
            this.lbTurno.Name = "lbTurno";
            this.lbTurno.Size = new System.Drawing.Size(91, 13);
            this.lbTurno.TabIndex = 11;
            this.lbTurno.Text = "Turno do Médico:";
            // 
            // txtTurno
            // 
            this.txtTurno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTurno.Cursor = System.Windows.Forms.Cursors.No;
            this.txtTurno.Location = new System.Drawing.Point(394, 73);
            this.txtTurno.Name = "txtTurno";
            this.txtTurno.ReadOnly = true;
            this.txtTurno.Size = new System.Drawing.Size(138, 20);
            this.txtTurno.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Horario:";
            // 
            // dateHorario
            // 
            this.dateHorario.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateHorario.Location = new System.Drawing.Point(394, 102);
            this.dateHorario.Name = "dateHorario";
            this.dateHorario.ShowUpDown = true;
            this.dateHorario.Size = new System.Drawing.Size(138, 20);
            this.dateHorario.TabIndex = 14;
            this.dateHorario.Value = new System.DateTime(2017, 6, 17, 8, 0, 0, 0);
            // 
            // frmAgendarConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 260);
            this.Controls.Add(this.dateHorario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTurno);
            this.Controls.Add(this.lbTurno);
            this.Controls.Add(this.dateData);
            this.Controls.Add(this.cbPaciente);
            this.Controls.Add(this.cbMedico);
            this.Controls.Add(this.cbAdmin);
            this.Controls.Add(this.lbAdmin);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.lbMedico);
            this.Controls.Add(this.lbPaciente);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Name = "frmAgendarConsulta";
            this.Text = "Agendar Consulta";
            this.Load += new System.EventHandler(this.frmAgendarConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsSecretaria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMedico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPaciente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lbPaciente;
        private System.Windows.Forms.Label lbMedico;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Label lbAdmin;
        private System.Windows.Forms.ComboBox cbAdmin;
        private System.Windows.Forms.ComboBox cbMedico;
        private System.Windows.Forms.ComboBox cbPaciente;
        private System.Windows.Forms.DateTimePicker dateData;
        private System.Windows.Forms.BindingSource bsSecretaria;
        private System.Windows.Forms.BindingSource bsMedico;
        private System.Windows.Forms.BindingSource bsPaciente;
        private System.Windows.Forms.Label lbTurno;
        private System.Windows.Forms.TextBox txtTurno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateHorario;
    }
}