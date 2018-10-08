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
    public partial class ctrlTrans : UserControl
    {
        public ctrlTrans()
        {
            InitializeComponent();

            //lblTransDate.Text = dtpTransDate.Value.ToShortDateString();
            
            //MessageBox.Show("red");

        }

        private void pnlControls_Click(object sender, EventArgs e)
        {
            formMain main = (formMain)this.Parent.Parent.Parent.Parent;

            
            main.lblTransID.Text = lblTransID.Text;
            main.dtpTrans.Value = Convert.ToDateTime(lblTransDate.Text);//dtpTransDate.Value;
            main.txtTransDecNum.Text = lblTransDeclarationNum.Text;
            main.cboStandard.SelectedValue = lblStandard.Text;
           


            
            
            main.cboTransExporter.SelectedValue = lblBranchAddress.Text;
          
            main.cboTransImporter.SelectedValue = lblTransImporter.Text;
            main.txtPort.Text = lblPort.Text;
            main.cboTransDestination.SelectedValue = lbldestination.Text;
        
            if (lblEportType.Text == "1")
            {
                main.radAir.Checked = true;
                main.radSea.Checked = false;
            }
            if (lblEportType.Text == "2")
            {
                main.radAir.Checked = false;
                main.radSea.Checked = true;
            }

            if (lblWithCO.Text == "False")
            {
                main.chkWithCO.Checked = false;
            }
            if (lblWithCO.Text == "True")
            {
                main.chkWithCO.Checked = true;
            }
            main.txtTransOriginCriterion.Text = lblOriginCriterion.Text;
            main.txtTransRemarks.Text = lblRemarks.Text;
            main.txtTransCoRefer.Text = lblCoReferenceNum.Text;

            main.txtVoyageNum.Text = lblVoyageNum.Text;
            main.txtATL.Text = lblATL.Text;
            main.cboTransVessel.SelectedValue = lblVessel.Text;
            main.cboTransExaminer.SelectedValue = lblExaminer.Text;

           

            foreach (Control userControl in this.Parent.Controls)
            {
                if (userControl is ctrlTrans && userControl != this)
                { 
                    userControl.BackColor = Color.White;
                    
                }

                
            }
            this.BackColor = Color.Teal;
            if (lblStatus.Text == "2")
            {
                this.BackColor = Color.Red;
                

            }


            main.productList();
            main.totalNetGross();
            main.transactionShow();


        }

        private void lblStatus_TextChanged(object sender, EventArgs e)
        {

            if (lblStatus.Text == "2")
            {
                lblSuperseded.Visible = true;
                //lblTransDate.ForeColor = Color.Red;
                //lblTransDeclarationNum.ForeColor = Color.Red;
                //MessageBox.Show("red");
            }
            else
            {
                lblSuperseded.Visible = false;
                //MessageBox.Show("white");
            }


        }

        private void lblTransDeclarationNum_TextChanged(object sender, EventArgs e)
        {
            //lblTransDate.Text = dtpTransDate.Value.ToShortDateString();
            
        }
    }
}
