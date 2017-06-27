using HospitalLib.Controler;
using HospitalModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalWindowsForm.view_admin.consulta
{
    public partial class frmConsultas : Form
    {
        public frmConsultas()
        {
            InitializeComponent();
        }

        public ConsultaControler control;
        private void frmConsultas_Load(object sender, EventArgs e)
        {
            control = new ConsultaControler();
            this.binding();
        }

        private void binding()
        {
            bsConsulta.DataSource = control.ObterObjetos();
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            frmRealizarConsulta form = new frmRealizarConsulta();
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.binding();
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            frmRealizarConsulta form = new frmRealizarConsulta();
            form.objeto = (Consulta)bsConsulta.Current;

            if (form.ShowDialog() == DialogResult.OK)
            {
                this.binding();
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            frmRealizarConsulta form = new frmRealizarConsulta();
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.binding();
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (bsConsulta.Current != null)
            {
                try
                {

                    control.RemoverObjeto((Consulta)bsConsulta.Current);

                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show("Não é possível deletar a Área de Atuação. Há outros dados vinculados a ele.", "Erro Interno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível deletar o registro. Tente novamente.", "Erro Interno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                this.binding();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
