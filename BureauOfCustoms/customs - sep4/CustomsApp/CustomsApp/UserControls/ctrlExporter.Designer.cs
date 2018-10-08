namespace CustomsApp.UserControls
{
    partial class ctrlExporter
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
            this.lblExporter = new System.Windows.Forms.Label();
            this.lblExporterID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.Color.White;
            this.pnlControls.Controls.Add(this.lblExporter);
            this.pnlControls.Controls.Add(this.lblExporterID);
            this.pnlControls.Controls.Add(this.label2);
            this.pnlControls.Location = new System.Drawing.Point(3, 3);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(304, 59);
            this.pnlControls.TabIndex = 5;
            this.pnlControls.Click += new System.EventHandler(this.pnlControls_Click);
            // 
            // lblExporter
            // 
            this.lblExporter.AutoSize = true;
            this.lblExporter.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExporter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.lblExporter.Location = new System.Drawing.Point(61, 18);
            this.lblExporter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExporter.Name = "lblExporter";
            this.lblExporter.Size = new System.Drawing.Size(130, 21);
            this.lblExporter.TabIndex = 6;
            this.lblExporter.Text = "Company Name";
            this.lblExporter.Click += new System.EventHandler(this.pnlControls_Click);
            // 
            // lblExporterID
            // 
            this.lblExporterID.AutoSize = true;
            this.lblExporterID.Location = new System.Drawing.Point(18, 77);
            this.lblExporterID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExporterID.Name = "lblExporterID";
            this.lblExporterID.Size = new System.Drawing.Size(13, 13);
            this.lblExporterID.TabIndex = 4;
            this.lblExporterID.Text = "1";
            this.lblExporterID.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Exporter:";
            this.label2.Click += new System.EventHandler(this.pnlControls_Click);
            // 
            // ctrlExporter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlControls);
            this.Name = "ctrlExporter";
            this.Size = new System.Drawing.Size(310, 65);
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlControls;
        public System.Windows.Forms.Label lblExporter;
        public System.Windows.Forms.Label lblExporterID;
        private System.Windows.Forms.Label label2;
    }
}
