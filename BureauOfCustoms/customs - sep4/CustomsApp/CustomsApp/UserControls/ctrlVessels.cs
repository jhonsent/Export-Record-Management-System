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
    public partial class ctrlVessels : UserControl
    {
        public ctrlVessels()
        {
            InitializeComponent();
        }

        private void pnlControls_Click(object sender, EventArgs e)
        {
            formMain main = (formMain)this.Parent.Parent.Parent.Parent;
            main.txtVesselName.Text = lblVesselName.Text;
            main.txtVesselID.Text = lblVesselID.Text;
            foreach (Control userControl in this.Parent.Controls)
            {
                if (userControl is ctrlVessels && userControl != this)
                    userControl.BackColor = Color.White;
            }
            this.BackColor = Color.Teal;
            main.btnDeleteVessel.Visible = true;
            main.btnEditVessel.Visible = true;
        }
    }
}
