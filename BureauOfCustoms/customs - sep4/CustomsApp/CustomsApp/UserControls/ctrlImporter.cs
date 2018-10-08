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
    public partial class ctrlImporter : UserControl
    {
        public ctrlImporter()
        {
            InitializeComponent();
        }
        private void pnlControls_Click(object sender, EventArgs e)
        {
            formMain main = (formMain)this.Parent.Parent.Parent.Parent;
            main.txtImporterName.Text = lblImporter.Text;
            main.txtImporterID.Text = lblImporterID.Text;
            foreach (Control userControl in this.Parent.Controls)
            {
                if (userControl is ctrlImporter && userControl != this)
                    userControl.BackColor = Color.White;
            }
            this.BackColor = Color.Teal;
            //pnlControls.BackColor = Color.LightCyan;

            main.btnEditImporter.Visible = true;
            main.btnDeleteImporter.Visible = true;


        }
    }
}
