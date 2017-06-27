using HospitalLib.Controler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalWindowsForm
{
    /*
     * @Author: Thiago Henrique You  
     * @Desc: Programa de controle e cadastros de consultas e agendamentos de um hospital
     * @Exec: Projeto para a disciplina de C#
     * @Version: 4.5
     */
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // variaveis de controle
            BancoControler bancoControl = new BancoControler();
            ConvenioControler convenioControl = new ConvenioControler();
            AreaAtuacaoControler areaAtuacaoControl = new AreaAtuacaoControler();
            PacienteControler pacienteControl = new PacienteControler();
            MedicoControler medicoControl = new MedicoControler();
            SecretariaControler secretariaControl = new SecretariaControler();
            AgendamentoControler agendamentoControl = new AgendamentoControler();

            // Popula a Base caso esteja vazia 
            if (bancoControl.ObterBancos().Count == 0){ bancoControl.PopularBase(); }
            if (convenioControl.ObterObjetos().Count == 0) { convenioControl.PopularBase(); }
            if (areaAtuacaoControl.ObterObjetos().Count == 0) { areaAtuacaoControl.PopularBase(); }
            if (pacienteControl.ObterObjetos().Count == 0) { pacienteControl.PopularBase(); }
            if (medicoControl.ObterMedicos().Count == 0) { medicoControl.PopularBase(); }
            if (secretariaControl.ObterObjetos().Count == 0) { secretariaControl.PopularBase(); }
            if (agendamentoControl.ObterObjetos().Count == 0) { agendamentoControl.PopularBase(); }

            Application.Run(new frmLogin());
        }
    }
}
