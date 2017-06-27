namespace HospitalWindowsForm
{
    partial class frmAdmin
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
            this.btnConsultarMedico = new System.Windows.Forms.Button();
            this.btnConsultarAdmin = new System.Windows.Forms.Button();
            this.btnConsultarPacientes = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnAgendarConsulta = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnConsultarBanco = new System.Windows.Forms.Button();
            this.btnConsultarAreaAtuacao = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConsultarMedico
            // 
            this.btnConsultarMedico.Location = new System.Drawing.Point(12, 12);
            this.btnConsultarMedico.Name = "btnConsultarMedico";
            this.btnConsultarMedico.Size = new System.Drawing.Size(150, 60);
            this.btnConsultarMedico.TabIndex = 3;
            this.btnConsultarMedico.Text = "Médicos";
            this.btnConsultarMedico.UseVisualStyleBackColor = true;
            this.btnConsultarMedico.Click += new System.EventHandler(this.btnConsultarMedico_Click);
            // 
            // btnConsultarAdmin
            // 
            this.btnConsultarAdmin.Location = new System.Drawing.Point(12, 94);
            this.btnConsultarAdmin.Name = "btnConsultarAdmin";
            this.btnConsultarAdmin.Size = new System.Drawing.Size(150, 60);
            this.btnConsultarAdmin.TabIndex = 4;
            this.btnConsultarAdmin.Text = "Administradores";
            this.btnConsultarAdmin.UseVisualStyleBackColor = true;
            this.btnConsultarAdmin.Click += new System.EventHandler(this.btnConsultarAdmin_Click);
            // 
            // btnConsultarPacientes
            // 
            this.btnConsultarPacientes.Location = new System.Drawing.Point(12, 176);
            this.btnConsultarPacientes.Name = "btnConsultarPacientes";
            this.btnConsultarPacientes.Size = new System.Drawing.Size(150, 60);
            this.btnConsultarPacientes.TabIndex = 5;
            this.btnConsultarPacientes.Text = "Pacientes";
            this.btnConsultarPacientes.UseVisualStyleBackColor = true;
            this.btnConsultarPacientes.Click += new System.EventHandler(this.btnConsultarPacientes_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.Location = new System.Drawing.Point(456, 265);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(120, 50);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnAgendarConsulta
            // 
            this.btnAgendarConsulta.Location = new System.Drawing.Point(376, 12);
            this.btnAgendarConsulta.Name = "btnAgendarConsulta";
            this.btnAgendarConsulta.Size = new System.Drawing.Size(150, 60);
            this.btnAgendarConsulta.TabIndex = 7;
            this.btnAgendarConsulta.Text = "Agendamentos";
            this.btnAgendarConsulta.UseVisualStyleBackColor = true;
            this.btnAgendarConsulta.Click += new System.EventHandler(this.btnAgendarConsulta_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(376, 94);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(150, 60);
            this.btnConsulta.TabIndex = 8;
            this.btnConsulta.Text = "Consultas";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnConsultarBanco
            // 
            this.btnConsultarBanco.Location = new System.Drawing.Point(194, 12);
            this.btnConsultarBanco.Name = "btnConsultarBanco";
            this.btnConsultarBanco.Size = new System.Drawing.Size(150, 60);
            this.btnConsultarBanco.TabIndex = 10;
            this.btnConsultarBanco.Text = "Bancos";
            this.btnConsultarBanco.UseVisualStyleBackColor = true;
            this.btnConsultarBanco.Click += new System.EventHandler(this.btnConsultarBanco_Click);
            // 
            // btnConsultarAreaAtuacao
            // 
            this.btnConsultarAreaAtuacao.Location = new System.Drawing.Point(194, 94);
            this.btnConsultarAreaAtuacao.Name = "btnConsultarAreaAtuacao";
            this.btnConsultarAreaAtuacao.Size = new System.Drawing.Size(150, 60);
            this.btnConsultarAreaAtuacao.TabIndex = 12;
            this.btnConsultarAreaAtuacao.Text = "Áreas de Atuação";
            this.btnConsultarAreaAtuacao.UseVisualStyleBackColor = true;
            this.btnConsultarAreaAtuacao.Click += new System.EventHandler(this.btnConsultarAreaAtuacao_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(194, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 60);
            this.button1.TabIndex = 13;
            this.button1.Text = "Convênios";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 327);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnConsultarAreaAtuacao);
            this.Controls.Add(this.btnConsultarBanco);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.btnAgendarConsulta);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnConsultarPacientes);
            this.Controls.Add(this.btnConsultarAdmin);
            this.Controls.Add(this.btnConsultarMedico);
            this.Name = "frmAdmin";
            this.Text = "Administrador";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnConsultarMedico;
        private System.Windows.Forms.Button btnConsultarAdmin;
        private System.Windows.Forms.Button btnConsultarPacientes;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnAgendarConsulta;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnConsultarBanco;
        private System.Windows.Forms.Button btnConsultarAreaAtuacao;
        private System.Windows.Forms.Button button1;
    }
}