
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using MaterialSkin;
using MaterialSkin.Controls;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace CustomsApp
{
    public partial class formLogin : Form
    {
        //public string conStr = "Data Source=DESKTOP-OV9HJA3\\SQLEXPRESS;Initial Catalog=CustomsDB;Integrated Security=True; User ID =admin;password=admin";
        

        SqlConnection SQLconnect = new SqlConnection();
        SqlCommand sqlCommand;
        SqlDataAdapter sqlDataAdapter;


        public formLogin()
        {
            InitializeComponent();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            formMain m = new formMain();
            SQLconnect.ConnectionString = m.conStr;


            SQLconnect.Close();
            sqlCommand = new SqlCommand("SELECT COUNT(*) from tblUser where username = '" + txtUsername.Text + "' and password = '" + txtPassword.Text + "'", SQLconnect);

            SQLconnect.Open();

            Int32 count = (Int32)sqlCommand.ExecuteScalar();

            SQLconnect.Close();
            
            if (count > 0)
            {
                SQLconnect.Close();
        
                SQLconnect.Open();
                sqlCommand = new SqlCommand("SELECT * from tblUser where username ='"+txtUsername.Text+"' and password = '"+txtPassword.Text+"'", SQLconnect);
                sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                DataSet dataSet = new DataSet();

                sqlDataAdapter.Fill(dataTable);

                

                //MessageBox.Show(dataTable.Rows[0]["userID"].ToString());



                this.Hide();
                formMain main = new formMain();
                
                main.Show();
                main.adminControl = dataTable.Rows[0]["adminControl"].ToString();
                main.userIDLOGIN = Convert.ToInt32(dataTable.Rows[0]["userID"].ToString());
                //main.lblUserIDLogin.Text = dataTable.Rows[0]["userID"].ToString();
                main.lblUsernameLogin.Text = "Welcome "+dataTable.Rows[0]["username"].ToString();


            }
            else
            {
                MessageBox.Show("Invalid Username or Password!");
            }
        }
    }
}
