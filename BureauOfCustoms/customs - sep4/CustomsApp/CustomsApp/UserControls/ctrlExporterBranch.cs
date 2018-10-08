using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomsApp.UserControls
{
    public partial class ctrlExporterBranch : UserControl
    {
        public ctrlExporterBranch()
        {
            InitializeComponent();
        }

        private void pnlControls_Click(object sender, EventArgs e)
        {

            formMain main = (formMain)this.Parent.Parent.Parent.Parent.Parent.Parent;
            main.txtBranchAddress.Text = lblExporterBranch.Text;
            main.txtBranchID.Text = lblExporterBranchID.Text;

          

            foreach (Control userControl in this.Parent.Controls)
            {
                if (userControl is ctrlExporterBranch && userControl != this)
                    userControl.BackColor = Color.White;
            }
            this.BackColor = Color.Teal;
            main.btnEditBranch.Visible = true;
            main.btnDeleteBranch.Visible = true;
        }
    }
}
