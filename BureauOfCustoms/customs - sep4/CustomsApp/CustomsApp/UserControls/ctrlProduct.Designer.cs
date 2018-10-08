namespace CustomsApp
{
    partial class ctrlProduct
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
            this.lbProductDescription = new System.Windows.Forms.Label();
            this.lblHSCode = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.Color.White;
            this.pnlControls.Controls.Add(this.lbProductDescription);
            this.pnlControls.Controls.Add(this.lblHSCode);
            this.pnlControls.Controls.Add(this.lblProductID);
            this.pnlControls.Controls.Add(this.label2);
            this.pnlControls.Controls.Add(this.label1);
            this.pnlControls.Location = new System.Drawing.Point(3, 3);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(304, 59);
            this.pnlControls.TabIndex = 3;
            this.pnlControls.Click += new System.EventHandler(this.pnlControls_Click);
            this.pnlControls.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlControls_Paint);
            this.pnlControls.Leave += new System.EventHandler(this.pnlControls_Leave);
            // 
            // lbProductDescription
            // 
            this.lbProductDescription.AutoSize = true;
            this.lbProductDescription.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.lbProductDescription.Location = new System.Drawing.Point(76, 24);
            this.lbProductDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbProductDescription.Name = "lbProductDescription";
            this.lbProductDescription.Size = new System.Drawing.Size(164, 21);
            this.lbProductDescription.TabIndex = 6;
            this.lbProductDescription.Text = "Banana Saba, Frozen";
            this.lbProductDescription.Click += new System.EventHandler(this.pnlControls_Click);
            // 
            // lblHSCode
            // 
            this.lblHSCode.AutoSize = true;
            this.lblHSCode.Location = new System.Drawing.Point(77, 10);
            this.lblHSCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHSCode.Name = "lblHSCode";
            this.lblHSCode.Size = new System.Drawing.Size(58, 13);
            this.lblHSCode.TabIndex = 5;
            this.lblHSCode.Text = "0811.9000";
            this.lblHSCode.Click += new System.EventHandler(this.pnlControls_Click);
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(18, 77);
            this.lblProductID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(13, 13);
            this.lblProductID.TabIndex = 4;
            this.lblProductID.Text = "1";
            this.lblProductID.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Product:";
            this.label2.Click += new System.EventHandler(this.pnlControls_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "HS CODE:";
            this.label1.Click += new System.EventHandler(this.pnlControls_Click);
            // 
            // ctrlProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlControls);
            this.Name = "ctrlProduct";
            this.Size = new System.Drawing.Size(310, 65);
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlControls;
        public System.Windows.Forms.Label lbProductDescription;
        public System.Windows.Forms.Label lblHSCode;
        public System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
