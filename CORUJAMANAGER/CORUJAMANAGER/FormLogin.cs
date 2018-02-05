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
            var ehLoginValido = new ProcessoDeLogin().ConsultaUsuarioLogin(ObtenhaParametros());

            if (!ehLoginValido) return;
            Form frm = new FormCaixa();
            frm.Show();
        }

        private SessaoDoUsuario ObtenhaParametros()
        {
            var sessaoDoUsuario = new SessaoDoUsuario
            {
                Aluno =
                {
                    Nome = txtNome.Text,
                    SenhaDeAcesso = txtSenha.Text
                }
            };

            return sessaoDoUsuario;
        }
    }
}
