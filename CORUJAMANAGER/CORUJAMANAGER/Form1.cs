using CORUJAMANAGER.ENTIDADESDENEGOCIO;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace CORUJAMANAGER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var estado = new Estado { Nome = "Goias" };
            var cidade = new Cidade("Goiania", estado);

            Debug.WriteLine($"Cidade: {cidade.Nome}, Estado: {cidade.Estado}");
        }
    }
}
