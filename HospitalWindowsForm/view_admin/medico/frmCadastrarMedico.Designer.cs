namespace HospitalWindowsForm.view_admin
{
    partial class frmCadastrarMedico
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
            this.lbNome = new System.Windows.Forms.Label();
            this.lbCrm = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbCpf = new System.Windows.Forms.Label();
            this.txtCrm = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.lblTurno = new System.Windows.Forms.Label();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.dateNasc = new System.Windows.Forms.DateTimePicker();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cbBanco = new System.Windows.Forms.ComboBox();
            this.bsBancos = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cbAreaAtuacao = new System.Windows.Forms.ComboBox();
            this.bsAreaAtuacao = new System.Windows.Forms.BindingSource(this.components);
            this.lbTelefone = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.cbTurno = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bsBancos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAreaAtuacao)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalvar.Location = new System.Drawing.Point(12, 243);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(120, 50);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lbNome
            // 
            this.lbNome.Location = new System.Drawing.Point(19, 13);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(41, 23);
            this.lbNome.TabIndex = 6;
            this.lbNome.Text = "Nome:";
            // 
            // lbCrm
            // 
            this.lbCrm.AutoSize = true;
            this.lbCrm.Location = new System.Drawing.Point(19, 56);
            this.lbCrm.Name = "lbCrm";
            this.lbCrm.Size = new System.Drawing.Size(34, 13);
            this.lbCrm.TabIndex = 2;
            this.lbCrm.Text = "CRM:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Área de Atuação:";
            // 
            // lbCpf
            // 
            this.lbCpf.AutoSize = true;
            this.lbCpf.Location = new System.Drawing.Point(19, 89);
            this.lbCpf.Name = "lbCpf";
            this.lbCpf.Size = new System.Drawing.Size(30, 13);
            this.lbCpf.TabIndex = 8;
            this.lbCpf.Text = "CPF:";
            // 
            // txtCrm
            // 
            this.txtCrm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCrm.Location = new System.Drawing.Point(119, 47);
            this.txtCrm.Name = "txtCrm";
            this.txtCrm.Size = new System.Drawing.Size(159, 20);
            this.txtCrm.TabIndex = 9;
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.Location = new System.Drawing.Point(119, 13);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(431, 20);
            this.txtNome.TabIndex = 10;
            // 
            // txtCpf
            // 
            this.txtCpf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCpf.Location = new System.Drawing.Point(119, 81);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(159, 20);
            this.txtCpf.TabIndex = 12;
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(19, 122);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(38, 13);
            this.lblTurno.TabIndex = 13;
            this.lblTurno.Text = "Turno:";
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.Location = new System.Drawing.Point(284, 82);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(92, 13);
            this.lblDataNasc.TabIndex = 16;
            this.lblDataNasc.Text = "Data Nascimento:";
            // 
            // dateNasc
            // 
            this.dateNasc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNasc.Location = new System.Drawing.Point(382, 81);
            this.dateNasc.Name = "dateNasc";
            this.dateNasc.Size = new System.Drawing.Size(168, 20);
            this.dateNasc.TabIndex = 17;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(430, 243);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 50);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Voltar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cbBanco
            // 
            this.cbBanco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBanco.DataSource = this.bsBancos;
            this.cbBanco.DisplayMember = "Nome";
            this.cbBanco.FormattingEnabled = true;
            this.cbBanco.Location = new System.Drawing.Point(119, 149);
            this.cbBanco.Name = "cbBanco";
            this.cbBanco.Size = new System.Drawing.Size(431, 21);
            this.cbBanco.TabIndex = 19;
            this.cbBanco.ValueMember = "Id";
            // 
            // bsBancos
            // 
            this.bsBancos.DataSource = typeof(HospitalModel.Banco);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Banco:";
            // 
            // cbAreaAtuacao
            // 
            this.cbAreaAtuacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAreaAtuacao.DataSource = this.bsAreaAtuacao;
            this.cbAreaAtuacao.DisplayMember = "Area";
            this.cbAreaAtuacao.FormattingEnabled = true;
            this.cbAreaAtuacao.Location = new System.Drawing.Point(119, 184);
            this.cbAreaAtuacao.Name = "cbAreaAtuacao";
            this.cbAreaAtuacao.Size = new System.Drawing.Size(431, 21);
            this.cbAreaAtuacao.TabIndex = 21;
            this.cbAreaAtuacao.ValueMember = "Id";
            // 
            // bsAreaAtuacao
            // 
            this.bsAreaAtuacao.DataSource = typeof(HospitalModel.AreaAtuacao);
            // 
            // lbTelefone
            // 
            this.lbTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Location = new System.Drawing.Point(287, 51);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(52, 13);
            this.lbTelefone.TabIndex = 22;
            this.lbTelefone.Text = "Telefone:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefone.Location = new System.Drawing.Point(382, 47);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(168, 20);
            this.txtTelefone.TabIndex = 23;
            // 
            // cbTurno
            // 
            this.cbTurno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTurno.FormattingEnabled = true;
            this.cbTurno.Items.AddRange(new object[] {
            "Diurno",
            "Noturno",
            "Madrugada"});
            this.cbTurno.Location = new System.Drawing.Point(119, 114);
            this.cbTurno.Name = "cbTurno";
            this.cbTurno.Size = new System.Drawing.Size(431, 21);
            this.cbTurno.TabIndex = 24;
            // 
            // frmCadastrarMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 305);
            this.Controls.Add(this.cbTurno);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.lbTelefone);
            this.Controls.Add(this.cbAreaAtuacao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbBanco);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dateNasc);
            this.Controls.Add(this.lblDataNasc);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCrm);
            this.Controls.Add(this.lbCpf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbCrm);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.btnSalvar);
            this.Name = "frmCadastrarMedico";
            this.Text = "frmCadastrarMedico";
            this.Load += new System.EventHandler(this.frmCadastrarMedico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsBancos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAreaAtuacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbCrm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbCpf;
        private System.Windows.Forms.TextBox txtCrm;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Label lblDataNasc;
        private System.Windows.Forms.DateTimePicker dateNasc;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cbBanco;
        private System.Windows.Forms.BindingSource bsBancos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAreaAtuacao;
        private System.Windows.Forms.BindingSource bsAreaAtuacao;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.ComboBox cbTurno;
    }
}