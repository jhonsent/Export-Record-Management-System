namespace CustomsApp.UserControls
{
    partial class ctrlExporterBranch
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
            this.lblExporterBranch = new System.Windows.Forms.Label();
            this.lblExporterBranchID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.Color.White;
            this.pnlControls.Controls.Add(this.lblExporterBranch);
            this.pnlControls.Controls.Add(this.lblExporterBranchID);
            this.pnlControls.Controls.Add(this.label2);
            this.pnlControls.Location = new System.Drawing.Point(3, 3);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(476, 38);
            this.pnlControls.TabIndex = 6;
            this.pnlControls.Click += new System.EventHandler(this.pnlControls_Click);
            // 
            // lblExporterBranch
            // 
            this.lblExporterBranch.AutoSize = true;
            this.lblExporterBranch.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExporterBranch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.lblExporterBranch.Location = new System.Drawing.Point(59, 7);
            this.lblExporterBranch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExporterBranch.Name = "lblExporterBranch";
            this.lblExporterBranch.Size = new System.Drawing.Size(142, 21);
            this.lblExporterBranch.TabIndex = 6;
            this.lblExporterBranch.Text = "Company Address";
            this.lblExporterBranch.Click += new System.EventHandler(this.pnlControls_Click);
            // 
            // lblExporterBranchID
            // 
            this.lblExporterBranchID.AutoSize = true;
            this.lblExporterBranchID.Location = new System.Drawing.Point(18, 77);
            this.lblExporterBranchID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExporterBranchID.Name = "lblExporterBranchID";
            this.lblExporterBranchID.Size = new System.Drawing.Size(13, 13);
            this.lblExporterBranchID.TabIndex = 4;
            this.lblExporterBranchID.Text = "1";
            this.lblExporterBranchID.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Address";
            this.label2.Click += new System.EventHandler(this.pnlControls_Click);
            // 
            // ctrlExporterBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlControls);
            this.Name = "ctrlExporterBranch";
            this.Size = new System.Drawing.Size(483, 45);
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlControls;
        public System.Windows.Forms.Label lblExporterBranch;
        public System.Windows.Forms.Label lblExporterBranchID;
        private System.Windows.Forms.Label label2;
    }
}
