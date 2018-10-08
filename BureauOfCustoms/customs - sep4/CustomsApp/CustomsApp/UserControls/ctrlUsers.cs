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
    public partial class ctrlUsers : UserControl
    {
        public ctrlUsers()
        {
            InitializeComponent();
        }

        private void pnlControls_Paint(object sender, PaintEventArgs e)
        {
           

        }

        private void pnlControls_Click(object sender, EventArgs e)
        {
            formMain main = (formMain)this.Parent.Parent.Parent.Parent;
            main.txtUsername.Text = lblUsername.Text;
            main.txtPassword.Text = lblPassword.Text;
            main.txtUserID.Text = lblUserID.Text;
            if(lblAdminControl.Text == "True")
            {
                main.chkAdmin.Checked = true;

            }
            if (lblAdminControl.Text == "False")
            {
                main.chkAdmin.Checked = false;

            }

            foreach (Control userControl in this.Parent.Controls)
            {
                if (userControl is ctrlUsers && userControl != this)
                    userControl.BackColor = Color.White;
            }
            this.BackColor = Color.Teal;
            //pnlControls.BackColor = Color.LightCyan;

            main.btnEditUser.Visible = true;
            main.btnDeleteUser.Visible = true;
        }
    }
}
