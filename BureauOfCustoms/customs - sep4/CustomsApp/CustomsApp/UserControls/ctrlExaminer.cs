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
    public partial class ctrlExaminer : UserControl
    {
        public ctrlExaminer()
        {
            InitializeComponent();
        }

        private void pnlControls_Click(object sender, EventArgs e)
        {
            formMain main = (formMain)this.Parent.Parent.Parent.Parent;
            main.txtFirstname.Text = lblFirstname.Text;
            main.txtMI.Text = lblMI.Text;
            main.txtLastname.Text = lblLastname.Text;
            main.txtExaminerID.Text = lblExaminerID.Text;
            foreach (Control userControl in this.Parent.Controls)
            {
                if (userControl is ctrlExaminer && userControl != this)
                    userControl.BackColor = Color.White;
            }
            this.BackColor = Color.Teal;
            //pnlControls.BackColor = Color.LightCyan;

            main.btnEditExaminer.Visible = true;
            main.btnDeleteExaminer.Visible = true;
        }

        private void ctrlExaminer_Click(object sender, EventArgs e)
        {
            

        }
    }
}
