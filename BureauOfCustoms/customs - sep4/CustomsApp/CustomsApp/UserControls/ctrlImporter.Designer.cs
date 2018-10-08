namespace CustomsApp.UserControls
{
    partial class ctrlImporter
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
            this.pnlControls = new System.Windows.Forms.Panel();
            this.lblImporter = new System.Windows.Forms.Label();
            this.lblImporterID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.Color.White;
            this.pnlControls.Controls.Add(this.lblImporter);
            this.pnlControls.Controls.Add(this.lblImporterID);
            this.pnlControls.Controls.Add(this.label2);
            this.pnlControls.Location = new System.Drawing.Point(3, 3);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(304, 59);
            this.pnlControls.TabIndex = 4;
            this.pnlControls.Click += new System.EventHandler(this.pnlControls_Click);
            // 
            // lblImporter
            // 
            this.lblImporter.AutoSize = true;
            this.lblImporter.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.lblImporter.Location = new System.Drawing.Point(61, 18);
            this.lblImporter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImporter.Name = "lblImporter";
            this.lblImporter.Size = new System.Drawing.Size(130, 21);
            this.lblImporter.TabIndex = 6;
            this.lblImporter.Text = "Company Name";
            this.lblImporter.Click += new System.EventHandler(this.pnlControls_Click);
            // 
            // lblImporterID
            // 
            this.lblImporterID.AutoSize = true;
            this.lblImporterID.Location = new System.Drawing.Point(18, 77);
            this.lblImporterID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImporterID.Name = "lblImporterID";
            this.lblImporterID.Size = new System.Drawing.Size(13, 13);
            this.lblImporterID.TabIndex = 4;
            this.lblImporterID.Text = "1";
            this.lblImporterID.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Importer:";
            this.label2.Click += new System.EventHandler(this.pnlControls_Click);
            // 
            // ctrlImporter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlControls);
            this.Name = "ctrlImporter";
            this.Size = new System.Drawing.Size(310, 65);
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlControls;
        public System.Windows.Forms.Label lblImporter;
        public System.Windows.Forms.Label lblImporterID;
        private System.Windows.Forms.Label label2;
    }
}
