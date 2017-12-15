using CORUJAMANAGER.ENTIDADESDENEGOCIO;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace CORUJAMANAGER
{
    public partial class FormBase : Form
    {
        private Label _lblNomeDaFuncao;
        private Panel _pnlBordaSuperior;

        public FormBase()
        {
            InitializeComponent();
        }

        private void FormBase_Load(object sender, EventArgs e)
        {

        }

        public void AjustaNomeDaFuncao(string nomeDaFuncionalidade)
        {
            _lblNomeDaFuncao.Text = nomeDaFuncionalidade;
        }
    }
}
