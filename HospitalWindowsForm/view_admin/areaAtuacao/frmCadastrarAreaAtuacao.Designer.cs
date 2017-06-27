namespace HospitalWindowsForm
{
    partial class frmCadastrarAreaAtuacao
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lbAreaAtuacao = new System.Windows.Forms.Label();
            this.txtAreaAtuacao = new System.Windows.Forms.TextBox();
            this.lbValor = new System.Windows.Forms.Label();
            this.mtValor = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalvar.Location = new System.Drawing.Point(12, 137);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(120, 50);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoltar.Location = new System.Drawing.Point(327, 137);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(120, 50);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lbAreaAtuacao
            // 
            this.lbAreaAtuacao.AutoSize = true;
            this.lbAreaAtuacao.Location = new System.Drawing.Point(12, 39);
            this.lbAreaAtuacao.Name = "lbAreaAtuacao";
            this.lbAreaAtuacao.Size = new System.Drawing.Size(90, 13);
            this.lbAreaAtuacao.TabIndex = 2;
            this.lbAreaAtuacao.Text = "Area de Atuação:";
            // 
            // txtAreaAtuacao
            // 
            this.txtAreaAtuacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAreaAtuacao.Location = new System.Drawing.Point(110, 36);
            this.txtAreaAtuacao.Name = "txtAreaAtuacao";
            this.txtAreaAtuacao.Size = new System.Drawing.Size(337, 20);
            this.txtAreaAtuacao.TabIndex = 3;
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Location = new System.Drawing.Point(15, 71);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(34, 13);
            this.lbValor.TabIndex = 4;
            this.lbValor.Text = "Valor:";
            // 
            // mtValor
            // 
            this.mtValor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mtValor.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.mtValor.Location = new System.Drawing.Point(110, 68);
            this.mtValor.Mask = "999.99";
            this.mtValor.Name = "mtValor";
            this.mtValor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtValor.Size = new System.Drawing.Size(337, 20);
            this.mtValor.TabIndex = 5;
            this.mtValor.Click += new System.EventHandler(this.mtValor_Click);
            // 
            // frmCadastrarAreaAtuacao
            // 
            this.ClientSize = new System.Drawing.Size(459, 199);
            this.Controls.Add(this.mtValor);
            this.Controls.Add(this.lbValor);
            this.Controls.Add(this.txtAreaAtuacao);
            this.Controls.Add(this.lbAreaAtuacao);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnSalvar);
            this.Name = "frmCadastrarAreaAtuacao";
            this.Text = "Cadastrar Area de Atuacao";
            this.Load += new System.EventHandler(this.frmCadastrarAreaAtuacao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lbAreaAtuacao;
        private System.Windows.Forms.TextBox txtAreaAtuacao;
        private System.Windows.Forms.Label lbValor;
        private System.Windows.Forms.MaskedTextBox mtValor;
    }
}
