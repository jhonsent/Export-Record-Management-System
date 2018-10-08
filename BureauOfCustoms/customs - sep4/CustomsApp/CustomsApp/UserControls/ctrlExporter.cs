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
    public partial class ctrlExporter : UserControl
    {
        public ctrlExporter()
        {
            InitializeComponent();
        }

        private void pnlControls_Click(object sender, EventArgs e)
        {
            formMain main = (formMain)this.Parent.Parent.Parent.Parent;
            main.txtExporterName.Text = lblExporter.Text;
            main.txtExporterID.Text = lblExporterID.Text;

   
            foreach (Control userControl in this.Parent.Controls)
            {
                if (userControl is ctrlExporter && userControl != this)
                    userControl.BackColor = Color.White;
            }
            this.BackColor = Color.Teal;
            //pnlControls.BackColor = Color.LightCyan;
            main.btnEditExporter.Visible = true;
            main.btnDeleteExporter.Visible = true;
            main.pnlBranchMain.Visible = true;

        }
    }
}
