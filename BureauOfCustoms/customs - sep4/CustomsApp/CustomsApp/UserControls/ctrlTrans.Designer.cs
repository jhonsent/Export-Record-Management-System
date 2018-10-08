namespace CustomsApp.UserControls
{
    partial class ctrlTrans
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTransDate = new System.Windows.Forms.Label();
            this.lblTransDeclarationNum = new System.Windows.Forms.Label();
            this.lblTransID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpTransDate = new System.Windows.Forms.DateTimePicker();
            this.lblStandard = new System.Windows.Forms.Label();
            this.lblEportType = new System.Windows.Forms.Label();
            this.lblBranchAddress = new System.Windows.Forms.Label();
            this.lblTransImporter = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.lbldestination = new System.Windows.Forms.Label();
            this.lblWithCO = new System.Windows.Forms.Label();
            this.lblOriginCriterion = new System.Windows.Forms.Label();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.lblCoReferenceNum = new System.Windows.Forms.Label();
            this.lblVoyageNum = new System.Windows.Forms.Label();
            this.lblATL = new System.Windows.Forms.Label();
            this.lblVessel = new System.Windows.Forms.Label();
            this.lblExaminer = new System.Windows.Forms.Label();
            this.lblSuperseded = new System.Windows.Forms.Label();
            this.pnlControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.Color.White;
            this.pnlControls.Controls.Add(this.lblSuperseded);
            this.pnlControls.Controls.Add(this.lblStatus);
            this.pnlControls.Controls.Add(this.label1);
            this.pnlControls.Controls.Add(this.lblTransDate);
            this.pnlControls.Controls.Add(this.lblTransDeclarationNum);
            this.pnlControls.Controls.Add(this.lblTransID);
            this.pnlControls.Controls.Add(this.label2);
            this.pnlControls.Location = new System.Drawing.Point(3, 3);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(304, 64);
            this.pnlControls.TabIndex = 5;
            this.pnlControls.Click += new System.EventHandler(this.pnlControls_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.lblStatus.Location = new System.Drawing.Point(186, 365);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(47, 19);
            this.lblStatus.TabIndex = 24;
            this.lblStatus.Text = "status";
            this.lblStatus.TextChanged += new System.EventHandler(this.lblStatus_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Date:";
            this.label1.Click += new System.EventHandler(this.pnlControls_Click);
            // 
            // lblTransDate
            // 
            this.lblTransDate.AutoSize = true;
            this.lblTransDate.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.lblTransDate.Location = new System.Drawing.Point(96, 7);
            this.lblTransDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransDate.Name = "lblTransDate";
            this.lblTransDate.Size = new System.Drawing.Size(80, 19);
            this.lblTransDate.TabIndex = 8;
            this.lblTransDate.Text = "Trans Date";
            this.lblTransDate.Click += new System.EventHandler(this.pnlControls_Click);
            // 
            // lblTransDeclarationNum
            // 
            this.lblTransDeclarationNum.AutoSize = true;
            this.lblTransDeclarationNum.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransDeclarationNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.lblTransDeclarationNum.Location = new System.Drawing.Point(96, 30);
            this.lblTransDeclarationNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransDeclarationNum.Name = "lblTransDeclarationNum";
            this.lblTransDeclarationNum.Size = new System.Drawing.Size(161, 21);
            this.lblTransDeclarationNum.TabIndex = 6;
            this.lblTransDeclarationNum.Text = "Declaration Number";
            this.lblTransDeclarationNum.TextChanged += new System.EventHandler(this.lblTransDeclarationNum_TextChanged);
            this.lblTransDeclarationNum.Click += new System.EventHandler(this.pnlControls_Click);
            // 
            // lblTransID
            // 
            this.lblTransID.AutoSize = true;
            this.lblTransID.Location = new System.Drawing.Point(18, 77);
            this.lblTransID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransID.Name = "lblTransID";
            this.lblTransID.Size = new System.Drawing.Size(13, 13);
            this.lblTransID.TabIndex = 4;
            this.lblTransID.Text = "1";
            this.lblTransID.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Declaration No:";
            this.label2.Click += new System.EventHandler(this.pnlControls_Click);
            // 
            // dtpTransDate
            // 
            this.dtpTransDate.Location = new System.Drawing.Point(60, 73);
            this.dtpTransDate.Name = "dtpTransDate";
            this.dtpTransDate.Size = new System.Drawing.Size(200, 20);
            this.dtpTransDate.TabIndex = 9;
            // 
            // lblStandard
            // 
            this.lblStandard.AutoSize = true;
            this.lblStandard.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStandard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.lblStandard.Location = new System.Drawing.Point(99, 96);
            this.lblStandard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStandard.Name = "lblStandard";
            this.lblStandard.Size = new System.Drawing.Size(68, 19);
            this.lblStandard.TabIndex = 10;
            this.lblStandard.Text = "Standard";
            // 
            // lblEportType
            // 
            this.lblEportType.AutoSize = true;
            this.lblEportType.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEportType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.lblEportType.Location = new System.Drawing.Point(99, 115);
            this.lblEportType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEportType.Name = "lblEportType";
            this.lblEportType.Size = new System.Drawing.Size(82, 19);
            this.lblEportType.TabIndex = 11;
            this.lblEportType.Text = "ExportType";
            // 
            // lblBranchAddress
            // 
            this.lblBranchAddress.AutoSize = true;
            this.lblBranchAddress.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBranchAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.lblBranchAddress.Location = new System.Drawing.Point(97, 134);
            this.lblBranchAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBranchAddress.Name = "lblBranchAddress";
            this.lblBranchAddress.Size = new System.Drawing.Size(90, 19);
            this.lblBranchAddress.TabIndex = 12;
            this.lblBranchAddress.Text = "Branch ADD";
            // 
            // lblTransImporter
            // 
            this.lblTransImporter.AutoSize = true;
            this.lblTransImporter.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransImporter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.lblTransImporter.Location = new System.Drawing.Point(99, 171);
            this.lblTransImporter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransImporter.Name = "lblTransImporter";
            this.lblTransImporter.Size = new System.Drawing.Size(66, 19);
            this.lblTransImporter.TabIndex = 13;
            this.lblTransImporter.Text = "importer";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.lblPort.Location = new System.Drawing.Point(101, 190);
            this.lblPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(36, 19);
            this.lblPort.TabIndex = 14;
            this.lblPort.Text = "port";
            // 
            // lbldestination
            // 
            this.lbldestination.AutoSize = true;
            this.lbldestination.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldestination.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.lbldestination.Location = new System.Drawing.Point(101, 209);
            this.lbldestination.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldestination.Name = "lbldestination";
            this.lbldestination.Size = new System.Drawing.Size(80, 19);
            this.lbldestination.TabIndex = 15;
            this.lbldestination.Text = "destination";
            // 
            // lblWithCO
            // 
            this.lblWithCO.AutoSize = true;
            this.lblWithCO.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWithCO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.lblWithCO.Location = new System.Drawing.Point(101, 228);
            this.lblWithCO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWithCO.Name = "lblWithCO";
            this.lblWithCO.Size = new System.Drawing.Size(57, 19);
            this.lblWithCO.TabIndex = 16;
            this.lblWithCO.Text = "withCO";
            // 
            // lblOriginCriterion
            // 
            this.lblOriginCriterion.AutoSize = true;
            this.lblOriginCriterion.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOriginCriterion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.lblOriginCriterion.Location = new System.Drawing.Point(99, 247);
            this.lblOriginCriterion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOriginCriterion.Name = "lblOriginCriterion";
            this.lblOriginCriterion.Size = new System.Drawing.Size(62, 19);
            this.lblOriginCriterion.TabIndex = 17;
            this.lblOriginCriterion.Text = "OrigCrit";
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemarks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.lblRemarks.Location = new System.Drawing.Point(107, 266);
            this.lblRemarks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(63, 19);
            this.lblRemarks.TabIndex = 18;
            this.lblRemarks.Text = "remarks";
            // 
            // lblCoReferenceNum
            // 
            this.lblCoReferenceNum.AutoSize = true;
            this.lblCoReferenceNum.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoReferenceNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.lblCoReferenceNum.Location = new System.Drawing.Point(107, 285);
            this.lblCoReferenceNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCoReferenceNum.Name = "lblCoReferenceNum";
            this.lblCoReferenceNum.Size = new System.Drawing.Size(62, 19);
            this.lblCoReferenceNum.TabIndex = 19;
            this.lblCoReferenceNum.Text = "RefNum";
            // 
            // lblVoyageNum
            // 
            this.lblVoyageNum.AutoSize = true;
            this.lblVoyageNum.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoyageNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.lblVoyageNum.Location = new System.Drawing.Point(105, 307);
            this.lblVoyageNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVoyageNum.Name = "lblVoyageNum";
            this.lblVoyageNum.Size = new System.Drawing.Size(84, 19);
            this.lblVoyageNum.TabIndex = 20;
            this.lblVoyageNum.Text = "voyagenum";
            // 
            // lblATL
            // 
            this.lblATL.AutoSize = true;
            this.lblATL.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblATL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.lblATL.Location = new System.Drawing.Point(103, 326);
            this.lblATL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblATL.Name = "lblATL";
            this.lblATL.Size = new System.Drawing.Size(26, 19);
            this.lblATL.TabIndex = 21;
            this.lblATL.Text = "atl";
            // 
            // lblVessel
            // 
            this.lblVessel.AutoSize = true;
            this.lblVessel.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVessel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.lblVessel.Location = new System.Drawing.Point(111, 345);
            this.lblVessel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVessel.Name = "lblVessel";
            this.lblVessel.Size = new System.Drawing.Size(46, 19);
            this.lblVessel.TabIndex = 22;
            this.lblVessel.Text = "vessel";
            // 
            // lblExaminer
            // 
            this.lblExaminer.AutoSize = true;
            this.lblExaminer.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExaminer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.lblExaminer.Location = new System.Drawing.Point(111, 368);
            this.lblExaminer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExaminer.Name = "lblExaminer";
            this.lblExaminer.Size = new System.Drawing.Size(70, 19);
            this.lblExaminer.TabIndex = 23;
            this.lblExaminer.Text = "examiner";
            // 
            // lblSuperseded
            // 
            this.lblSuperseded.AutoSize = true;
            this.lblSuperseded.BackColor = System.Drawing.Color.Transparent;
            this.lblSuperseded.Font = new System.Drawing.Font("PT Bold Arch", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblSuperseded.ForeColor = System.Drawing.Color.Red;
            this.lblSuperseded.Location = new System.Drawing.Point(215, 0);
            this.lblSuperseded.Name = "lblSuperseded";
            this.lblSuperseded.Size = new System.Drawing.Size(89, 22);
            this.lblSuperseded.TabIndex = 25;
            this.lblSuperseded.Text = "Superseded";
            this.lblSuperseded.Click += new System.EventHandler(this.pnlControls_Click);
            // 
            // ctrlTrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblExaminer);
            this.Controls.Add(this.lblVessel);
            this.Controls.Add(this.lblATL);
            this.Controls.Add(this.lblVoyageNum);
            this.Controls.Add(this.lblCoReferenceNum);
            this.Controls.Add(this.lblRemarks);
            this.Controls.Add(this.lblOriginCriterion);
            this.Controls.Add(this.lblWithCO);
            this.Controls.Add(this.lbldestination);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.lblTransImporter);
            this.Controls.Add(this.lblBranchAddress);
            this.Controls.Add(this.lblEportType);
            this.Controls.Add(this.lblStandard);
            this.Controls.Add(this.dtpTransDate);
            this.Controls.Add(this.pnlControls);
            this.Name = "ctrlTrans";
            this.Size = new System.Drawing.Size(309, 71);
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblTransDeclarationNum;
        public System.Windows.Forms.Label lblTransID;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblTransDate;
        public System.Windows.Forms.DateTimePicker dtpTransDate;
        public System.Windows.Forms.Label lblStandard;
        public System.Windows.Forms.Label lblEportType;
        public System.Windows.Forms.Label lblBranchAddress;
        public System.Windows.Forms.Label lblTransImporter;
        public System.Windows.Forms.Label lblPort;
        public System.Windows.Forms.Label lbldestination;
        public System.Windows.Forms.Label lblWithCO;
        public System.Windows.Forms.Label lblOriginCriterion;
        public System.Windows.Forms.Label lblRemarks;
        public System.Windows.Forms.Label lblCoReferenceNum;
        public System.Windows.Forms.Label lblVoyageNum;
        public System.Windows.Forms.Label lblATL;
        public System.Windows.Forms.Label lblVessel;
        public System.Windows.Forms.Label lblExaminer;
        public System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblSuperseded;
    }
}
