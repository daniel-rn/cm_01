using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace CORUJAMANAGER.Controles
{
    public partial class ControleGrid : UserControl
    {
        public ControleGrid(BindingSource bindingSource)
        {
            InitializeComponent();
            dgvControle.DataSource = bindingSource;
        }

        private void pcbAdicionar_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Adicionar");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Adicionar");
        }
    }
}
