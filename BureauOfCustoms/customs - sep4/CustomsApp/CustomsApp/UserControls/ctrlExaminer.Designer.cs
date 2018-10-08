namespace CustomsApp.UserControls
{
    partial class ctrlExaminer
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
            this.lblFullname = new System.Windows.Forms.Label();
            this.lblExaminerID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.lblMI = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.pnlControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.Color.White;
            this.pnlControls.Controls.Add(this.lblLastname);
            this.pnlControls.Controls.Add(this.lblMI);
            this.pnlControls.Controls.Add(this.lblFirstname);
            this.pnlControls.Controls.Add(this.lblFullname);
            this.pnlControls.Controls.Add(this.lblExaminerID);
            this.pnlControls.Controls.Add(this.label2);
            this.pnlControls.Location = new System.Drawing.Point(3, 3);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(304, 32);
            this.pnlControls.TabIndex = 4;
            this.pnlControls.Click += new System.EventHandler(this.pnlControls_Click);
            // 
            // lblFullname
            // 
            this.lblFullname.AutoSize = true;
            this.lblFullname.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.lblFullname.Location = new System.Drawing.Point(42, 5);
            this.lblFullname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFullname.Name = "lblFullname";
            this.lblFullname.Size = new System.Drawing.Size(164, 21);
            this.lblFullname.TabIndex = 6;
            this.lblFullname.Text = "Banana Saba, Frozen";
            this.lblFullname.Click += new System.EventHandler(this.pnlControls_Click);
            // 
            // lblExaminerID
            // 
            this.lblExaminerID.AutoSize = true;
            this.lblExaminerID.Location = new System.Drawing.Point(18, 77);
            this.lblExaminerID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExaminerID.Name = "lblExaminerID";
            this.lblExaminerID.Size = new System.Drawing.Size(13, 13);
            this.lblExaminerID.TabIndex = 4;
            this.lblExaminerID.Text = "1";
            this.lblExaminerID.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name:";
            this.label2.Click += new System.EventHandler(this.pnlControls_Click);
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Location = new System.Drawing.Point(18, 104);
            this.lblFirstname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(13, 13);
            this.lblFirstname.TabIndex = 7;
            this.lblFirstname.Text = "1";
            this.lblFirstname.Visible = false;
            // 
            // lblMI
            // 
            this.lblMI.AutoSize = true;
            this.lblMI.Location = new System.Drawing.Point(18, 117);
            this.lblMI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMI.Name = "lblMI";
            this.lblMI.Size = new System.Drawing.Size(13, 13);
            this.lblMI.TabIndex = 8;
            this.lblMI.Text = "1";
            this.lblMI.Visible = false;
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Location = new System.Drawing.Point(18, 143);
            this.lblLastname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(13, 13);
            this.lblLastname.TabIndex = 9;
            this.lblLastname.Text = "1";
            this.lblLastname.Visible = false;
            // 
            // ctrlExaminer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlControls);
            this.Name = "ctrlExaminer";
            this.Size = new System.Drawing.Size(311, 39);
            this.Click += new System.EventHandler(this.ctrlExaminer_Click);
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlControls;
        public System.Windows.Forms.Label lblLastname;
        public System.Windows.Forms.Label lblMI;
        public System.Windows.Forms.Label lblFirstname;
        public System.Windows.Forms.Label lblFullname;
        public System.Windows.Forms.Label lblExaminerID;
        private System.Windows.Forms.Label label2;
    }
}
