namespace CORUJAMANAGER
{
    partial class FormLogin
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gboLogin = new System.Windows.Forms.GroupBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.pbLogin = new System.Windows.Forms.PictureBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.MaskedTextBox();
            this.gboLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // gboLogin
            // 
            this.gboLogin.Controls.Add(this.txtSenha);
            this.gboLogin.Controls.Add(this.txtNome);
            this.gboLogin.Controls.Add(this.pbLogin);
            this.gboLogin.Controls.Add(this.lblSenha);
            this.gboLogin.Controls.Add(this.lblNome);
            this.gboLogin.Location = new System.Drawing.Point(12, 68);
            this.gboLogin.Name = "gboLogin";
            this.gboLogin.Size = new System.Drawing.Size(537, 232);
            this.gboLogin.TabIndex = 1;
            this.gboLogin.TabStop = false;
            this.gboLogin.Text = "Informações Login";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(16, 34);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(39, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(16, 56);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(43, 13);
            this.lblSenha.TabIndex = 1;
            this.lblSenha.Text = "Senha";
            // 
            // pbLogin
            // 
            this.pbLogin.Image = global::CORUJAMANAGER.Properties.Resources.if_Login_in_85205;
            this.pbLogin.Location = new System.Drawing.Point(235, 90);
            this.pbLogin.Name = "pbLogin";
            this.pbLogin.Size = new System.Drawing.Size(32, 32);
            this.pbLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbLogin.TabIndex = 2;
            this.pbLogin.TabStop = false;
            this.pbLogin.Click += new System.EventHandler(this.pbLogin_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(73, 30);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(194, 20);
            this.txtNome.TabIndex = 3;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(73, 52);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(194, 20);
            this.txtSenha.TabIndex = 4;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.gboLogin);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.Controls.SetChildIndex(this.gboLogin, 0);
            this.gboLogin.ResumeLayout(false);
            this.gboLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gboLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblNome;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.MaskedTextBox txtSenha;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.PictureBox pbLogin;
    }
}