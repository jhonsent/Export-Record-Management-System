namespace CustomsApp.UserControls
{
    partial class ctrlProductSearch
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
            this.txtGross = new System.Windows.Forms.TextBox();
            this.txtNet = new System.Windows.Forms.TextBox();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboProduct = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteProductSelection = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblHSCode = new System.Windows.Forms.Label();
            this.cboHSCODE = new System.Windows.Forms.ComboBox();
            this.txtProdID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtGross
            // 
            this.txtGross.Location = new System.Drawing.Point(566, 29);
            this.txtGross.Name = "txtGross";
            this.txtGross.Size = new System.Drawing.Size(224, 20);
            this.txtGross.TabIndex = 110;
            // 
            // txtNet
            // 
            this.txtNet.Location = new System.Drawing.Point(331, 29);
            this.txtNet.Name = "txtNet";
            this.txtNet.Size = new System.Drawing.Size(161, 20);
            this.txtNet.TabIndex = 109;
            // 
            // txtVolume
            // 
            this.txtVolume.Location = new System.Drawing.Point(58, 29);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(199, 20);
            this.txtVolume.TabIndex = 108;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 107;
            this.label4.Text = "Volume";
            // 
            // cboProduct
            // 
            this.cboProduct.FormattingEnabled = true;
            this.cboProduct.Location = new System.Drawing.Point(58, 3);
            this.cboProduct.Name = "cboProduct";
            this.cboProduct.Size = new System.Drawing.Size(434, 21);
            this.cboProduct.TabIndex = 106;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(511, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 105;
            this.label3.Text = "Gross";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 104;
            this.label2.Text = "Net";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(511, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 103;
            this.label1.Text = "HSCode";
            // 
            // btnDeleteProductSelection
            // 
            this.btnDeleteProductSelection.Depth = 0;
            this.btnDeleteProductSelection.Location = new System.Drawing.Point(730, 4);
            this.btnDeleteProductSelection.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteProductSelection.Name = "btnDeleteProductSelection";
            this.btnDeleteProductSelection.Primary = true;
            this.btnDeleteProductSelection.Size = new System.Drawing.Size(61, 21);
            this.btnDeleteProductSelection.TabIndex = 102;
            this.btnDeleteProductSelection.Text = "Remove";
            this.btnDeleteProductSelection.UseVisualStyleBackColor = true;
            this.btnDeleteProductSelection.Click += new System.EventHandler(this.btnDeleteProductSelection_Click);
            // 
            // lblHSCode
            // 
            this.lblHSCode.AutoSize = true;
            this.lblHSCode.Location = new System.Drawing.Point(7, 6);
            this.lblHSCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHSCode.Name = "lblHSCode";
            this.lblHSCode.Size = new System.Drawing.Size(44, 13);
            this.lblHSCode.TabIndex = 101;
            this.lblHSCode.Text = "Product";
            // 
            // cboHSCODE
            // 
            this.cboHSCODE.FormattingEnabled = true;
            this.cboHSCODE.Location = new System.Drawing.Point(566, 3);
            this.cboHSCODE.Name = "cboHSCODE";
            this.cboHSCODE.Size = new System.Drawing.Size(159, 21);
            this.cboHSCODE.TabIndex = 111;
            // 
            // txtProdID
            // 
            this.txtProdID.Location = new System.Drawing.Point(301, 79);
            this.txtProdID.Name = "txtProdID";
            this.txtProdID.Size = new System.Drawing.Size(199, 20);
            this.txtProdID.TabIndex = 112;
            // 
            // ctrlProductSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtProdID);
            this.Controls.Add(this.cboHSCODE);
            this.Controls.Add(this.txtGross);
            this.Controls.Add(this.txtNet);
            this.Controls.Add(this.txtVolume);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboProduct);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteProductSelection);
            this.Controls.Add(this.lblHSCode);
            this.Name = "ctrlProductSearch";
            this.Size = new System.Drawing.Size(801, 55);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtGross;
        public System.Windows.Forms.TextBox txtNet;
        public System.Windows.Forms.TextBox txtVolume;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox cboProduct;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialRaisedButton btnDeleteProductSelection;
        public System.Windows.Forms.Label lblHSCode;
        public System.Windows.Forms.ComboBox cboHSCODE;
        public System.Windows.Forms.TextBox txtProdID;
    }
}
