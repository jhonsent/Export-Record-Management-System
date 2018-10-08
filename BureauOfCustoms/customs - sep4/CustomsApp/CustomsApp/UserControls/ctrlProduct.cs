using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomsApp
{
    public partial class ctrlProduct : UserControl
    {
        
        public ctrlProduct()
        {
            InitializeComponent();
        }

        private void pnlControls_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlControls_Click(object sender, EventArgs e)
        {
            formMain main = (formMain)this.Parent.Parent.Parent.Parent;
            main.txtHSCOde.Text = lblHSCode.Text;
            main.txtProductDescription.Text = lbProductDescription.Text;
            main.txtProductID.Text = lblProductID.Text;
            foreach (Control userControl in this.Parent.Controls)
            {
                if (userControl is ctrlProduct && userControl != this)
                    userControl.BackColor = Color.White;
            }
            this.BackColor = Color.Teal;
            //pnlControls.BackColor = Color.LightCyan;
       
            main.btnEditProd.Visible = true;
            main.btnDeleteProd.Visible = true;
        

        }

        public formMain MainForm
        {
            get
            {
                var parent = Parent;
                while (parent != null && (parent as formMain) == null)
                {
                    parent = parent.Parent;
                }
                return parent as formMain;
            }



        }

        private void pnlControls_Leave(object sender, EventArgs e)
        {
            
        }
    }
}
