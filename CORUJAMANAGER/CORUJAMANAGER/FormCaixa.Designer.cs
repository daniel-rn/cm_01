namespace CORUJAMANAGER
{
    partial class FormCaixa
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
            this.controleGrid1 = new CORUJAMANAGER.Controles.ControleGrid();
            this.SuspendLayout();
            // 
            // controleGrid1
            // 
            this.controleGrid1.Location = new System.Drawing.Point(281, 156);
            this.controleGrid1.Name = "controleGrid1";
            this.controleGrid1.Size = new System.Drawing.Size(499, 305);
            this.controleGrid1.TabIndex = 1;
            this.controleGrid1.Load += new System.EventHandler(this.controleGrid1_Load);
            // 
            // FormCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.controleGrid1);
            this.Name = "FormCaixa";
            this.Text = "FormCaixa";
            this.Controls.SetChildIndex(this.controleGrid1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.ControleGrid controleGrid1;
    }
}