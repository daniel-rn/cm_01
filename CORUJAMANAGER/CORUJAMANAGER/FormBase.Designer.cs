namespace CORUJAMANAGER
{
    partial class FormBase
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBase));
            this._pnlBordaSuperior = new System.Windows.Forms.Panel();
            this._lblNomeDaFuncao = new System.Windows.Forms.Label();
            this._pnlBordaSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // _pnlBordaSuperior
            // 
            this._pnlBordaSuperior.BackColor = System.Drawing.Color.SeaGreen;
            this._pnlBordaSuperior.Controls.Add(this._lblNomeDaFuncao);
            this._pnlBordaSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this._pnlBordaSuperior.ForeColor = System.Drawing.Color.DarkKhaki;
            this._pnlBordaSuperior.Location = new System.Drawing.Point(0, 0);
            this._pnlBordaSuperior.Name = "_pnlBordaSuperior";
            this._pnlBordaSuperior.Size = new System.Drawing.Size(884, 62);
            this._pnlBordaSuperior.TabIndex = 0;
            // 
            // _lblNomeDaFuncao
            // 
            this._lblNomeDaFuncao.AutoSize = true;
            this._lblNomeDaFuncao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblNomeDaFuncao.ForeColor = System.Drawing.Color.White;
            this._lblNomeDaFuncao.Location = new System.Drawing.Point(597, 19);
            this._lblNomeDaFuncao.Name = "_lblNomeDaFuncao";
            this._lblNomeDaFuncao.Size = new System.Drawing.Size(183, 25);
            this._lblNomeDaFuncao.TabIndex = 0;
            this._lblNomeDaFuncao.Text = "Nome da funcao";
            // 
            // FormBase
            // 
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this._pnlBordaSuperior);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "FormBase";
            this.Load += new System.EventHandler(this.FormBase_Load);
            this._pnlBordaSuperior.ResumeLayout(false);
            this._pnlBordaSuperior.PerformLayout();
            this.ResumeLayout(false);

        }
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>

        #endregion
    }
}

