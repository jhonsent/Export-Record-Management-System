using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace CustomsApp.UserControls
{
    public partial class ctrlProductSearch : UserControl
    {
        //string conStr = "Data Source=DESKTOP-OV9HJA3\\SQLEXPRESS;Initial Catalog=CustomsDB;Integrated Security=True; User ID =admin;password=admin";

        SqlConnection SQLconnect = new SqlConnection();
        //SqlCommand sqlCommand;
        //SqlDataAdapter sqlDataAdapter;


        public ctrlProductSearch()
        {
            InitializeComponent();
            this.BackColor = Color.White;

            fillcboProd();
            //btnDeleteProductSelection.Enabled = false;
        }

        public void fillcboProd()
        {


            SQLconnect.Close();
            formMain m = new formMain();
            SQLconnect.ConnectionString = m.conStr;

            //SQLconnect.ConnectionString = conStr;
            SQLconnect.Open();
            SqlCommand sc = new SqlCommand("SELECT * from tblProduct", SQLconnect);
            SqlDataReader reader;

            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("productDescription", typeof(string));
            dt.Columns.Add("productID", typeof(int));
            dt.Load(reader);
            //UserControls.ctrlProductSearch prod = new UserControls.ctrlProductSearch();
            cboProduct.DataSource = dt;
            cboProduct.ValueMember = "productID";
            cboProduct.DisplayMember = "productDescription";
            cboHSCODE.DataSource = dt;
            cboHSCODE.ValueMember = "productID";
            cboHSCODE.DisplayMember = "hsCode";
            SQLconnect.Close();


        }
        private void pnlControls_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pnlControls_Click(object sender, EventArgs e)
        {
        
            
        }

        private void btnDeleteProductSelection_Click(object sender, EventArgs e)
        {

            Control myControl = this;
            while (myControl.Parent != null)
            {
                
                if (myControl.Parent != null)
                {
                    
                    myControl = myControl.Parent;
  
                    if (myControl.Name == "pnlProductListContainer")
                    {
           
                        myControl.Controls.Remove(this);
                    }
      
                }

            }
        }
       
 
       
    }
}
