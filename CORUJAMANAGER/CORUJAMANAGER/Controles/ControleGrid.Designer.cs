namespace CORUJAMANAGER.Controles
{
    partial class ControleGrid
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvControle = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pcbAdicionar = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvControle)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAdicionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvControle
            // 
            this.dgvControle.AllowUserToAddRows = false;
            this.dgvControle.AllowUserToDeleteRows = false;
            this.dgvControle.AllowUserToResizeRows = false;
            this.dgvControle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvControle.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvControle.Location = new System.Drawing.Point(0, 0);
            this.dgvControle.MinimumSize = new System.Drawing.Size(200, 200);
            this.dgvControle.Name = "dgvControle";
            this.dgvControle.Size = new System.Drawing.Size(465, 305);
            this.dgvControle.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.pcbAdicionar);
            this.flowLayoutPanel2.Controls.Add(this.pictureBox2);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(468, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(31, 305);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // pcbAdicionar
            // 
            this.pcbAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbAdicionar.Image = global::CORUJAMANAGER.Properties.Resources.plus_24;
            this.pcbAdicionar.Location = new System.Drawing.Point(3, 5);
            this.pcbAdicionar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.pcbAdicionar.Name = "pcbAdicionar";
            this.pcbAdicionar.Size = new System.Drawing.Size(24, 24);
            this.pcbAdicionar.TabIndex = 0;
            this.pcbAdicionar.TabStop = false;
            this.pcbAdicionar.Click += new System.EventHandler(this.pcbAdicionar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CORUJAMANAGER.Properties.Resources.minus_32_red;
            this.pictureBox2.Location = new System.Drawing.Point(3, 35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // ControleGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.dgvControle);
            this.Name = "ControleGrid";
            this.Size = new System.Drawing.Size(499, 305);
            ((System.ComponentModel.ISupportInitialize)(this.dgvControle)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbAdicionar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvControle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox pcbAdicionar;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
