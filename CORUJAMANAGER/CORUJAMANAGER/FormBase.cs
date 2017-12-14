using CORUJAMANAGER.ENTIDADESDENEGOCIO;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace CORUJAMANAGER
{
    public partial class FormBase : Form
    {
        private Label lblNomeDaFuncao;
        private Panel pnlBordaSuperior;

        public FormBase()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var estado = new Estado { Nome = "Goias" };
            var cidade = new Cidade("Goiania", estado);

            Debug.WriteLine($"Cidade: {cidade.Nome}, Estado: {cidade.Estado}");
        }

        private void InitializeComponent()
        {
            this.pnlBordaSuperior = new System.Windows.Forms.Panel();
            this.lblNomeDaFuncao = new System.Windows.Forms.Label();
            this.pnlBordaSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBordaSuperior
            // 
            this.pnlBordaSuperior.BackColor = System.Drawing.Color.SeaGreen;
            this.pnlBordaSuperior.Controls.Add(this.lblNomeDaFuncao);
            this.pnlBordaSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBordaSuperior.ForeColor = System.Drawing.Color.DarkKhaki;
            this.pnlBordaSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlBordaSuperior.Name = "pnlBordaSuperior";
            this.pnlBordaSuperior.Size = new System.Drawing.Size(884, 62);
            this.pnlBordaSuperior.TabIndex = 0;
            // 
            // lblNomeDaFuncao
            // 
            this.lblNomeDaFuncao.AutoSize = true;
            this.lblNomeDaFuncao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeDaFuncao.ForeColor = System.Drawing.Color.White;
            this.lblNomeDaFuncao.Location = new System.Drawing.Point(597, 19);
            this.lblNomeDaFuncao.Name = "lblNomeDaFuncao";
            this.lblNomeDaFuncao.Size = new System.Drawing.Size(183, 25);
            this.lblNomeDaFuncao.TabIndex = 0;
            this.lblNomeDaFuncao.Text = "Nome da funcao";
            // 
            // FormBase
            // 
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.pnlBordaSuperior);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "FormBase";
            this.pnlBordaSuperior.ResumeLayout(false);
            this.pnlBordaSuperior.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
