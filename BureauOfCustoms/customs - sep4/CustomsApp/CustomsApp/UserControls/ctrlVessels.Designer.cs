namespace CustomsApp.UserControls
{
    partial class ctrlVessels
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
            this.lblVesselName = new System.Windows.Forms.Label();
            this.lblVesselID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.Color.White;
            this.pnlControls.Controls.Add(this.lblVesselName);
            this.pnlControls.Controls.Add(this.lblVesselID);
            this.pnlControls.Controls.Add(this.label2);
            this.pnlControls.Location = new System.Drawing.Point(3, 3);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(304, 59);
            this.pnlControls.TabIndex = 4;
            this.pnlControls.Click += new System.EventHandler(this.pnlControls_Click);
            // 
            // lblVesselName
            // 
            this.lblVesselName.AutoSize = true;
            this.lblVesselName.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVesselName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.lblVesselName.Location = new System.Drawing.Point(61, 18);
            this.lblVesselName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVesselName.Name = "lblVesselName";
            this.lblVesselName.Size = new System.Drawing.Size(105, 21);
            this.lblVesselName.TabIndex = 6;
            this.lblVesselName.Text = "Vessel Name";
            this.lblVesselName.Click += new System.EventHandler(this.pnlControls_Click);
            // 
            // lblVesselID
            // 
            this.lblVesselID.AutoSize = true;
            this.lblVesselID.Location = new System.Drawing.Point(18, 77);
            this.lblVesselID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVesselID.Name = "lblVesselID";
            this.lblVesselID.Size = new System.Drawing.Size(13, 13);
            this.lblVesselID.TabIndex = 4;
            this.lblVesselID.Text = "1";
            this.lblVesselID.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vessel:";
            this.label2.Click += new System.EventHandler(this.pnlControls_Click);
            // 
            // ctrlVessels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlControls);
            this.Name = "ctrlVessels";
            this.Size = new System.Drawing.Size(310, 66);
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlControls;
        public System.Windows.Forms.Label lblVesselName;
        public System.Windows.Forms.Label lblVesselID;
        private System.Windows.Forms.Label label2;
    }
}
