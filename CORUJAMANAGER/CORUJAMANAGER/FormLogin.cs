using System;
using System.Windows.Forms;
using CORUJAMANAGER.ENTIDADESDENEGOCIO;
using CORUJAMANAGER.PROCESSOS;

namespace CORUJAMANAGER
{
    public partial class FormLogin : FormBase
    {
        public FormLogin()
        {
            InitializeComponent();
            AjustaNomeDaFuncao("Login");
        }

        private void pbLogin_Click(object sender, EventArgs e)
        {
            ObtenhaParametros();
            var teste = new ProcessoDeLogin().ConsultaUsuarioLogin(ObtenhaParametros());

            if (teste)
            {
                Form frm = new FormCaixa();
                frm.Show();
            }
        }

        private DtoLogin ObtenhaParametros()
        {
            var dtoLogin = new DtoLogin();
            dtoLogin.Aluno.Nome = txtNome.Text;
            dtoLogin.Aluno.SenhaDeAcesso = txtSenha.Text;

            return dtoLogin;
        }
    }
}
