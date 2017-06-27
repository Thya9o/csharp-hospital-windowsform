namespace HospitalWindowsForm.view_medico
{
    partial class frmAgendamentos
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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.bsAgendamentos = new System.Windows.Forms.BindingSource(this.components);
            this.gridAgendamentos = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataAgendadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secretariaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsAgendamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAgendamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoltar.Location = new System.Drawing.Point(535, 236);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(120, 50);
            this.btnVoltar.TabIndex = 0;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // bsAgendamentos
            // 
            this.bsAgendamentos.DataSource = typeof(HospitalModel.Agendamento);
            // 
            // gridAgendamentos
            // 
            this.gridAgendamentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridAgendamentos.AutoGenerateColumns = false;
            this.gridAgendamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAgendamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dataAgendadaDataGridViewTextBoxColumn,
            this.pacienteDataGridViewTextBoxColumn,
            this.secretariaDataGridViewTextBoxColumn});
            this.gridAgendamentos.DataSource = this.bsAgendamentos;
            this.gridAgendamentos.Location = new System.Drawing.Point(12, 12);
            this.gridAgendamentos.Name = "gridAgendamentos";
            this.gridAgendamentos.Size = new System.Drawing.Size(643, 218);
            this.gridAgendamentos.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Cod";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // dataAgendadaDataGridViewTextBoxColumn
            // 
            this.dataAgendadaDataGridViewTextBoxColumn.DataPropertyName = "DataAgendada";
            this.dataAgendadaDataGridViewTextBoxColumn.HeaderText = "DataAgendada";
            this.dataAgendadaDataGridViewTextBoxColumn.Name = "dataAgendadaDataGridViewTextBoxColumn";
            this.dataAgendadaDataGridViewTextBoxColumn.Width = 150;
            // 
            // pacienteDataGridViewTextBoxColumn
            // 
            this.pacienteDataGridViewTextBoxColumn.DataPropertyName = "Paciente";
            this.pacienteDataGridViewTextBoxColumn.HeaderText = "Paciente";
            this.pacienteDataGridViewTextBoxColumn.Name = "pacienteDataGridViewTextBoxColumn";
            this.pacienteDataGridViewTextBoxColumn.Width = 200;
            // 
            // secretariaDataGridViewTextBoxColumn
            // 
            this.secretariaDataGridViewTextBoxColumn.DataPropertyName = "Secretaria";
            this.secretariaDataGridViewTextBoxColumn.HeaderText = "Secretaria";
            this.secretariaDataGridViewTextBoxColumn.Name = "secretariaDataGridViewTextBoxColumn";
            this.secretariaDataGridViewTextBoxColumn.Width = 200;
            // 
            // frmAgendamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 298);
            this.Controls.Add(this.gridAgendamentos);
            this.Controls.Add(this.btnVoltar);
            this.Name = "frmAgendamentos";
            this.Text = "Agendamentos";
            this.Load += new System.EventHandler(this.frmAgendamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsAgendamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAgendamentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.BindingSource bsAgendamentos;
        private System.Windows.Forms.DataGridView gridAgendamentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataAgendadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secretariaDataGridViewTextBoxColumn;
    }
}