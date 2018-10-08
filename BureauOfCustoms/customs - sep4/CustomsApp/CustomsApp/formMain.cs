
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
using Microsoft.Reporting.WinForms;
using System.Globalization;

namespace CustomsApp
{
    public partial class formMain : MaterialForm
    {
   
        public string conStr = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=CustomsDB;Integrated Security=True; User ID =admin;password=admin";
        public int userIDLOGIN, selectedbtn=0;
        public string adminControl;
        string firstname = "", lastname="", mi="",hsCode = "", importerName = "", vesselName ="", exporterName="", exporterAddress="", username ="";
        SqlConnection SQLconnect = new SqlConnection();
        SqlCommand sqlCommand;
        SqlDataAdapter sqlDataAdapter;
        DataTable dataTable = new DataTable();
        int rptEx = 0;
        DataTable sqlDataTable;


        public formMain()
        {
            InitializeComponent();



            SQLconnect.ConnectionString = conStr;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal500, Primary.Teal700, Primary.Teal200, Accent.Lime100, TextShade.WHITE);

            //formLogin login = new formLogin();

          


        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialTabControl1_Selected(object sender, TabControlEventArgs e)
        {
            selectedbtn = 0;
            switch ((sender as TabControl).SelectedIndex)
            {
                case 0:
                    dashboard();
                    break;
                case 1:
                    products();
                    break;
                case 2:
                    exporters();
                    break;
                case 3:
                    importers();
                    break;
                case 4:
                    vessels();
                    break;
                case 5:
                    transactions();
                    break;
                case 6:
                    reports();
                    break;
                case 7:
                    userCheck();
                    //users();
                    break;
                case 8:
                    examiners();
                    break;

            }
            
        }
        public void dashboard()
        {
        }
        public void products()
        {

            txtHSCOde.Text = "";
            txtProductDescription.Text = "";
            txtProductID.Text = "";
            txtSearchProd.Text = "";
            pnlProd.Enabled = false;
            pnlSearchProd.Enabled = true;
            pnlProductContainer.Enabled = true;
            btnAddProd.Visible = true;
            btnEditProd.Visible = false;
            btnDeleteProd.Visible = false;
            btnSaveProd.Visible = false;
            btnCancelProd.Visible = false;




            SQLconnect.Close();
            ////
            SQLconnect.Open();
            sqlCommand = new SqlCommand("SELECT * from tblProduct", SQLconnect);
            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            DataSet dataSet = new DataSet();

            sqlDataAdapter.Fill(dataTable);
            pnlProductContainer.Controls.Clear();
            for (int row = 0; row <= dataTable.Rows.Count - 1; row++)
            {
                ctrlProduct product = new ctrlProduct();
                product.lblHSCode.Text = dataTable.Rows[row]["hsCode"].ToString();
                product.lblProductID.Text = dataTable.Rows[row]["productID"].ToString();
                product.lbProductDescription.Text = dataTable.Rows[row]["productDescription"].ToString();

                pnlProductContainer.Controls.Add(product);
            }
            SQLconnect.Close();
        }
        public void exporters()
        {

            txtExporterName.Text = "";
            txtExporterID.Text = "";
            txtSearchExporter.Text = "";
            pnlExporter.Enabled = false;
            pnlSearchExporter.Enabled = true;
            pnlExporterContainer.Enabled = true;
            btnAddExporter.Visible = true;
            btnEditExporter.Visible = false;
            btnDeleteExporter.Visible = false;
            btnSaveExporter.Visible = false;
            btnCancelExporter.Visible = false;

            pnlBranchMain.Visible = false;
            pnlBranchMain.Enabled = true;
            btnAddBranch.Visible = true;
            btnEditBranch.Visible = false;
            btnDeleteBranch.Visible = false;
            btnSaveBranch.Visible = false;
            btnCancelBranch.Visible = false;
            pnlBranch.Enabled = false;
            pnlExporterBranchContainer.Enabled = true ;

            

            SQLconnect.Close();
            ////
            SQLconnect.Open();
            sqlCommand = new SqlCommand("SELECT * from tblExporter", SQLconnect);
            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            DataSet dataSet = new DataSet();

            sqlDataAdapter.Fill(dataTable);
            pnlExporterContainer.Controls.Clear();
            for (int row = 0; row <= dataTable.Rows.Count - 1; row++)
            {
                UserControls.ctrlExporter exporter = new UserControls.ctrlExporter();
                exporter.lblExporter.Text = dataTable.Rows[row]["exporterName"].ToString();
                exporter.lblExporterID.Text = dataTable.Rows[row]["exporterID"].ToString();

                pnlExporterContainer.Controls.Add(exporter);
            }
            SQLconnect.Close();
        }
        public void importers()
        {

            txtImporterName.Text = "";
            txtImporterID.Text = "";
            txtSearchImporter.Text = "";
            pnlImporter.Enabled = false;
            pnlSearchImporter.Enabled = true;
            pnlImporterContainer.Enabled = true;
            btnAddImporter.Visible = true;
            btnEditImporter.Visible = false;
            btnDeleteImporter.Visible = false;
            btnSaveImporter.Visible = false;
            btnCancelImporter.Visible = false;




            SQLconnect.Close();
            ////
            SQLconnect.Open();
            sqlCommand = new SqlCommand("SELECT * from tblImporter", SQLconnect);
            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            DataSet dataSet = new DataSet();

            sqlDataAdapter.Fill(dataTable);
            pnlImporterContainer.Controls.Clear();
            for (int row = 0; row <= dataTable.Rows.Count - 1; row++)
            {
                UserControls.ctrlImporter importer = new UserControls.ctrlImporter();
                importer.lblImporter.Text = dataTable.Rows[row]["importerName"].ToString();
                importer.lblImporterID.Text = dataTable.Rows[row]["importerID"].ToString();
        
                pnlImporterContainer.Controls.Add(importer);
            }
            SQLconnect.Close();
        }
        public void vessels()
        {
            txtVesselName.Text = "";
            txtVesselID.Text = "";
            txtSearchVessel.Text = "";
            pnlVessel.Enabled = false;
            pnlSearchVessel.Enabled = true;
            pnlVesselContainer.Enabled = true;
            btnAddVessel.Visible = true;
            btnEditVessel.Visible = false;
            btnDeleteVessel.Visible = false;
            btnSaveVessel.Visible = false;
            btnCancelVessel.Visible = false;
            




            SQLconnect.Close();
            ////
            SQLconnect.Open();
            sqlCommand = new SqlCommand("SELECT * from tblVessel", SQLconnect);
            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            DataSet dataSet = new DataSet();

            sqlDataAdapter.Fill(dataTable);
            pnlVesselContainer.Controls.Clear();
            for (int row = 0; row <= dataTable.Rows.Count - 1; row++)
            {
                UserControls.ctrlVessels vessels = new UserControls.ctrlVessels();
                vessels.lblVesselName.Text = dataTable.Rows[row]["vesselName"].ToString();
                vessels.lblVesselID.Text = dataTable.Rows[row]["vesselID"].ToString();

                pnlVesselContainer.Controls.Add(vessels);
            }
            SQLconnect.Close();
            
        }
        public class ComboboxItem
        {
            public object Value { get; set; }
            public string Text { get; set; }

            public override string ToString() { return Text; }
        }
        public void fillcboTransExaminer()
        {
            SQLconnect.Close();
            ////
            SQLconnect.Open();
            SqlCommand sc = new SqlCommand("SELECT examinerID, lastname + ', ' + firstname + ' ' + mi as fullname from tblExaminer", SQLconnect);
            SqlDataReader reader;

            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("fullname", typeof(string));
            dt.Columns.Add("examinerID", typeof(int));
            dt.Load(reader);
            cboTransExaminer.DataSource = dt;
            cboTransExaminer.ValueMember = "examinerID";
            cboTransExaminer.DisplayMember = "fullname";

            SQLconnect.Close();

        }
        public void fillcboTransVessel()
        {
            SQLconnect.Close();
            ////
            SQLconnect.Open();
            SqlCommand sc = new SqlCommand("SELECT * from tblVessel", SQLconnect);
            SqlDataReader reader;

            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("vesselName", typeof(string));
            dt.Columns.Add("vesselID", typeof(int));
            dt.Load(reader);
            cboTransVessel.DataSource = dt;
            cboTransVessel.ValueMember = "vesselID";
            cboTransVessel.DisplayMember = "vesselName";

            SQLconnect.Close();

        }
        private void autoCompleteTextbox1_TextChanged(object sender, EventArgs e)
        {
           
                
        }

        public void fillcboStandard()
        {
            SQLconnect.Close();
            SQLconnect.Open();
            SqlCommand sc = new SqlCommand("SELECT * from tblTransStandard ", SQLconnect);
            //SqlCommand sc = new SqlCommand("SELECT * from tblTransStandard where transStandardCode  LIKE '%" +cboStandard.Text+ "%' ", SQLconnect);

            SqlDataReader reader;

            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            DataSet ds = new DataSet("DB");
            dt.Columns.Add("transStandardCode", typeof(string));
            dt.Columns.Add("transStandardID", typeof(int));
            dt.Load(reader);
            cboStandard.DataSource = dt;
            cboStandard.ValueMember = "transStandardID";
            cboStandard.DisplayMember = "transStandardCode";

       
            SQLconnect.Close();

        }
        


        public void fillcboTransExporter()
        {
            //cboTransExporter.Items.Clear();
            SQLconnect.Close();
            ////
            SQLconnect.Open();
            //SqlCommand sc = new SqlCommand("SELECT * from tblExporter", SQLconnect);
            SqlCommand sc = new SqlCommand("select exporterBranchID, exporterNAme +', ' + exporterAddress as exporter from tblExporter inner join tblExporterBranch on tblExporter.exporterID = tblExporterBranch.exporterID", SQLconnect);


            //SqlCommand sc = new SqlCommand("select exporterBranchID, exporterNAme from tblExporter inner join tblExporterBranch on tblExporter.exporterID = tblExporterBranch.exporterID", SQLconnect);
            SqlDataReader reader;

            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("exporter", typeof(string));
            dt.Columns.Add("exporterBranchID", typeof(int));
            dt.Load(reader);
            cboTransExporter.DataSource = dt;
            cboTransExporter.ValueMember = "exporterBranchID";
            cboTransExporter.DisplayMember = "exporter";
            
            SQLconnect.Close();

        }
        public void fillcboTransExporterNoFilter()
        {
            //cboTransExporter.Items.Clear();
            SQLconnect.Close();
            ////
            SQLconnect.Open();
            SqlCommand sc = new SqlCommand("SELECT * from tblExporter", SQLconnect);
    
            SqlDataReader reader;

            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("exporterName", typeof(string));
            dt.Columns.Add("exporterID", typeof(int));
            dt.Load(reader);
            cboTransExporter.DataSource = dt;
            cboTransExporter.ValueMember = "exporterID";
            cboTransExporter.DisplayMember = "exporterName";

            SQLconnect.Close();

        }
        public void fillcboTransImporter()
        {
            SQLconnect.Close();
            ////
            SQLconnect.Open();
            SqlCommand sc = new SqlCommand("SELECT * from tblImporter", SQLconnect);
            SqlDataReader reader;

            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("importerName", typeof(string));
            dt.Columns.Add("importerID", typeof(int));
            dt.Load(reader);
            cboTransImporter.DataSource = dt;
            cboTransImporter.ValueMember = "importerID";
            cboTransImporter.DisplayMember = "importerName";

            SQLconnect.Close();
        }
        public void fillcboTransDestination()
        {
            SQLconnect.Close();
            ////
            SQLconnect.Open();
            SqlCommand sc = new SqlCommand("SELECT * from tblDestination", SQLconnect);
            SqlDataReader reader;

            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("destinationName", typeof(string));
            dt.Columns.Add("destinationID", typeof(int));
            dt.Load(reader);
            cboTransDestination.DataSource = dt;
            cboTransDestination.ValueMember = "destinationID";
            cboTransDestination.DisplayMember = "destinationName";

            SQLconnect.Close();

        }
       
       

        public void productList()
        {
            SQLconnect.Close();
            ////
            SQLconnect.Open();
            //sqlCommand = new SqlCommand("SELECT *  from tblTransProductList where transID = "+transID+"", SQLconnect);
            sqlCommand = new SqlCommand("select transID, tblProduct.productID, hsCode, volume, net, gross from tblTransProductList inner join tblProduct on tblTransProductList.productID = tblProduct.productID where transID = "+lblTransID.Text+"", SQLconnect);
            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            DataSet dataSet = new DataSet();

            sqlDataAdapter.Fill(dataTable);
            pnlProductListContainer.Controls.Clear();
            for (int row = 0; row <= dataTable.Rows.Count - 1; row++)
            {
                UserControls.ctrlProductSearch prod = new UserControls.ctrlProductSearch();
             
                prod.cboProduct.SelectedValue = dataTable.Rows[row]["productID"].ToString();
                //prod.txtHSCODE.Text = dataTable.Rows[row]["hsCode"].ToString();
                prod.txtVolume.Text = dataTable.Rows[row]["volume"].ToString();
                prod.txtGross.Text = dataTable.Rows[row]["gross"].ToString();
                prod.txtNet.Text = dataTable.Rows[row]["net"].ToString();

                pnlProductListContainer.Controls.Add(prod);
            }
            SQLconnect.Close();

        }
        public void fillcboProd()
        {
           

            SQLconnect.Close();
            ////
            SQLconnect.Open();
            SqlCommand sc = new SqlCommand("SELECT * from tblProduct", SQLconnect);
            SqlDataReader reader;

            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("productDescription", typeof(string));
            dt.Columns.Add("productID", typeof(int));
            dt.Load(reader);
            UserControls.ctrlProductSearch prod = new UserControls.ctrlProductSearch();
            prod.cboProduct.DataSource = dt;
            prod.cboProduct.ValueMember = "productID";
            prod.cboProduct.DisplayMember = "productDescription";
            SQLconnect.Close();


        }
        public void transactions()
        {
            pnlTransContainer.Controls.Clear();
            
            SQLconnect.Close();
           
            SQLconnect.Open();
            sqlCommand = new SqlCommand("SELECT *  from tblTransaction ORDER BY transDate DESC;", SQLconnect);
            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            DataSet dataSet = new DataSet();

            sqlDataAdapter.Fill(dataTable);
            pnlTransContainer.Controls.Clear();
            for (int row = 0; row <= dataTable.Rows.Count - 1; row++)
            {
                UserControls.ctrlTrans trans = new UserControls.ctrlTrans();
                trans.lblTransID.Text = dataTable.Rows[row]["transID"].ToString();
                ////////DateTime dt = System.DateTime.Parse(dataTable.Rows[row]["transDate"].ToString());
                ///////////trans.dtpTransDate.Value = dt;//dtpTrans.Value.Date.ToString("yyyyMMdd") 
                //trans.dtpTransDate.Value = dataTable.Rows[row]["transDate"].ToString(yyyyMMdd);
                //trans.lblTransDate.Text = dataTable.Rows[row]["transDate"].ToString("yyyyMMdd"); //
                //////////
                trans.lblTransDate.Text= dataTable.Rows[row]["transDate"].ToString();
                trans.lblTransDeclarationNum.Text = dataTable.Rows[row]["transDeclarationNum"].ToString();
                trans.lblStandard.Text = dataTable.Rows[row]["transStandardID"].ToString();
                trans.lblEportType.Text = dataTable.Rows[row]["exportTypeID"].ToString();
                trans.lblBranchAddress.Text = dataTable.Rows[row]["exporterBranchID"].ToString();
                trans.lblTransImporter.Text = dataTable.Rows[row]["importerID"].ToString();
                trans.lblPort.Text = dataTable.Rows[row]["portOrigin"].ToString();
                trans.lbldestination.Text = dataTable.Rows[row]["destinationID"].ToString();
                trans.lblWithCO.Text = dataTable.Rows[row]["withCO"].ToString();
                trans.lblOriginCriterion.Text = dataTable.Rows[row]["originCriterion"].ToString();
                trans.lblRemarks.Text = dataTable.Rows[row]["remarks"].ToString();
                trans.lblCoReferenceNum.Text = dataTable.Rows[row]["coReferenceNum"].ToString();
                trans.lblVoyageNum.Text = dataTable.Rows[row]["voyageNum"].ToString();
                trans.lblATL.Text = dataTable.Rows[row]["atl"].ToString();

                trans.lblVessel.Text = dataTable.Rows[row]["vesselID"].ToString();
                trans.lblExaminer.Text = dataTable.Rows[row]["examinerID"].ToString();
                trans.lblStatus.Text = dataTable.Rows[row]["statusID"].ToString();

                pnlTransContainer.Controls.Add(trans);
            }
            SQLconnect.Close();


            
            fillcboStandard();
            fillcboTransExporter();
            fillcboTransImporter();
            fillcboTransDestination();
            fillcboTransVessel();
            fillcboTransExaminer();
            newTransaction();
            pnlTransMain.Visible = false;
            btnCancelTransaction.Visible = false;
            btnCancelTransaction2.Visible = false;
            btnSaveTransaction.Visible = false;



        }
        public void reports()
        {
        }
        public void userCheck()
        {
            //MessageBox.Show(adminControl);
            if (adminControl == "True")
            {
                users();
            }
            if (adminControl == "False")
            {
                
                MessageBox.Show("You are not allowed to open this page!");
                materialTabControl1.SelectedTab = tabPage1;
                dashboard();
            }
        }
        public void users()
        {

            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUserID.Text = "";
            txtSearchUser.Text = "";
            pnlUser.Enabled = false;
            pnlSearchUser.Enabled = true;
            pnlUserContainer.Enabled = true;
            btnAddUser.Visible = true;
            btnEditUser.Visible = false;
            btnDeleteUser.Visible = false;
            btnSaveUser.Visible = false;
            btnCancelUser.Visible = false;




            SQLconnect.Close();
            ////
            SQLconnect.Open();
            sqlCommand = new SqlCommand("SELECT * from tblUser", SQLconnect);
            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            DataSet dataSet = new DataSet();

            sqlDataAdapter.Fill(dataTable);
            pnlUserContainer.Controls.Clear();
            for (int row = 0; row <= dataTable.Rows.Count - 1; row++)
            {
                UserControls.ctrlUsers user = new UserControls.ctrlUsers();
                user.lblUserID.Text = dataTable.Rows[row]["userID"].ToString();
                user.lblUsername.Text = dataTable.Rows[row]["username"].ToString();
                user.lblPassword.Text = dataTable.Rows[row]["password"].ToString();
                user.lblAdminControl.Text = dataTable.Rows[row]["adminControl"].ToString();

                pnlUserContainer.Controls.Add(user);
            }
            SQLconnect.Close();
        }
        public void examiners()
        {
            txtFirstname.Text = "";
            txtLastname.Text = "";
            txtExaminerID.Text = "";
            txtMI.Text = "";
            txtSearchExaminer.Text = "";
            pnlExaminer.Enabled = false;
            pnlSearchExaminer.Enabled = true;
            pnlExaminerContainer.Enabled = true;
            btnAddExaminer.Visible = true;
            btnEditExaminer.Visible = false;
            btnDeleteExaminer.Visible = false;
            btnSaveExaminer.Visible = false;
            btnCancelExaminer.Visible = false;




            SQLconnect.Close();
            ////
            SQLconnect.Open();
            sqlCommand = new SqlCommand("SELECT * from tblExaminer", SQLconnect);
            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            DataSet dataSet = new DataSet();

            sqlDataAdapter.Fill(dataTable);
            pnlExaminerContainer.Controls.Clear();
            for (int row = 0; row <= dataTable.Rows.Count - 1; row++)
            {
                UserControls.ctrlExaminer examiner = new UserControls.ctrlExaminer();
                examiner.lblExaminerID.Text = dataTable.Rows[row]["examinerID"].ToString();
                examiner.lblFirstname.Text = dataTable.Rows[row]["firstname"].ToString();
                examiner.lblMI.Text = dataTable.Rows[row]["mi"].ToString();
                examiner.lblLastname.Text = dataTable.Rows[row]["lastname"].ToString();
                examiner.lblFullname.Text = examiner.lblLastname.Text + ", " + examiner.lblFirstname.Text + " " + examiner.lblMI.Text;

                pnlExaminerContainer.Controls.Add(examiner);
            }
            SQLconnect.Close();
        }
        public void transactionShow()
        {
            pnlTransMain.Visible = true;
            btnCancelTransaction.Visible = true;
            btnCancelTransaction2.Visible = false;
            btnSaveTransaction.Visible = false;

        }

        private void btnClearProd_Click(object sender, EventArgs e)
        {
            txtSearchProd.Text = "";
        }
        public void examinerAddEdit()
        {
            pnlExaminer.Enabled = true;
            pnlSearchExaminer.Enabled = false;
            pnlExaminerContainer.Enabled = false;
            btnAddExaminer.Visible = false;
            btnEditExaminer.Visible = false;
            btnDeleteExaminer.Visible = false;
            btnSaveExaminer.Visible = true;
            btnCancelExaminer.Visible = true;
        }
        public void userAddEdit()
        {
            pnlUser.Enabled = true;
            pnlSearchUser.Enabled = false;
            pnlUserContainer.Enabled = false;
            btnAddUser.Visible = false;
            btnEditUser.Visible = false;
            btnDeleteUser.Visible = false;
            btnSaveUser.Visible = true;
            btnCancelUser.Visible = true;
        }
        public void productAddEdit()
        {
            pnlProd.Enabled = true;
            pnlSearchProd.Enabled = false;
            pnlProductContainer.Enabled = false;
            btnAddProd.Visible = false;
            btnEditProd.Visible = false;
            btnDeleteProd.Visible = false;
            btnSaveProd.Visible = true;
            btnCancelProd.Visible = true;
        }
        private void btnAddProd_Click(object sender, EventArgs e)
        {

            txtHSCOde.Text = "";
            txtProductDescription.Text = "";

            productAddEdit();
            

            selectedbtn = 1;

        }

        private void txtProductID_TextChanged(object sender, EventArgs e)
        {
            
            btnEditProd.Enabled = true;
            btnDeleteProd.Enabled = true;

        }

        private void btnEditProd_Click(object sender, EventArgs e)
        {
            hsCode = txtHSCOde.Text;
            productAddEdit();
            selectedbtn = 2;

        }

        private void btnDeleteProd_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to delete this product?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                SQLconnect.Close();
                //
                sqlCommand = new SqlCommand("DELETE from tblProduct where productID =" + txtProductID.Text + " ", SQLconnect);
    
                SQLconnect.Open();
                try
                {
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }

                SQLconnect.Close();
                products();
            }
        }

        private void btnSaveProd_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedbtn == 1)
                {

                    if (txtHSCOde.Text != "" && txtProductDescription.Text != "")
                    {
                        SQLconnect.Close();
                        //
                        sqlCommand = new SqlCommand("SELECT COUNT(*) from tblProduct where hsCode = '" + txtHSCOde.Text + "'", SQLconnect);

                        SQLconnect.Open();

                        Int32 count = (Int32)sqlCommand.ExecuteScalar();

                        SQLconnect.Close();
                        //MessageBox.Show(count.ToString());
                        if (count > 0)
                        {
                            MessageBox.Show("HSCODE already exist!");
                        }
                        else
                        {
                            SQLconnect.Close();
                            //
                            sqlCommand = new SqlCommand("INSERT INTO tblProduct (hsCode, productDescription) values('" + txtHSCOde.Text + "','" + txtProductDescription.Text + "')", SQLconnect);

                            SQLconnect.Open();

                            sqlCommand.ExecuteNonQuery();

                            SQLconnect.Close();
                            MessageBox.Show("Product added successfully",
                            "Data Saved",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information,
                            MessageBoxDefaultButton.Button1);
                            products();
                        }
                    }
                    else
                    {

                        MessageBox.Show("Product details is incomplete",
                        "Data incomplete",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1);

                    }
                }
                if (selectedbtn == 2)
                {
                    if (txtHSCOde.Text != "" && txtProductDescription.Text != "")
                    {
                        SQLconnect.Close();
                        //
                        sqlCommand = new SqlCommand("SELECT COUNT(*) from tblProduct where hsCode = '" + txtHSCOde.Text + "' and hsCode <> '" + hsCode + "'", SQLconnect);

                        SQLconnect.Open();

                        Int32 count = (Int32)sqlCommand.ExecuteScalar();

                        SQLconnect.Close();
                        //MessageBox.Show(count.ToString());
                        if (count > 0)
                        {
                            MessageBox.Show("HSCODE already exist!");
                        }
                        else
                        {
                            SQLconnect.Close();
                            //
                            sqlCommand = new SqlCommand("Update tblProduct set hsCode = '" + txtHSCOde.Text + "', productDescription = '" + txtProductDescription.Text + "' where productID = " + txtProductID.Text + " ", SQLconnect);

                            SQLconnect.Open();

                            sqlCommand.ExecuteNonQuery();

                            SQLconnect.Close();
                            MessageBox.Show("Product updated successfully",
                            "Data Saved",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information,
                            MessageBoxDefaultButton.Button1);
                            products();
                        }

                    }
                    else
                    {

                        MessageBox.Show("Product details is incomplete",
                        "Data incomplete",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1);

                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelProd_Click(object sender, EventArgs e)
        {
            products();
        }

        private void panel12_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void txtSearchProd_TextChanged(object sender, EventArgs e)
        {
            SQLconnect.Close();
            //
            SQLconnect.Open();
            sqlCommand = new SqlCommand("SELECT * from tblProduct where hsCode LIKE '%" + txtSearchProd.Text + "%' or productDescription LIKE '%" + txtSearchProd.Text + "%'", SQLconnect);
            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            DataSet dataSet = new DataSet();

            sqlDataAdapter.Fill(dataTable);
            pnlProductContainer.Controls.Clear();
            for (int row = 0; row <= dataTable.Rows.Count - 1; row++)
            {
                ctrlProduct product = new ctrlProduct();
                product.lblHSCode.Text = dataTable.Rows[row]["hsCode"].ToString();
                product.lblProductID.Text = dataTable.Rows[row]["productID"].ToString();
                product.lbProductDescription.Text = dataTable.Rows[row]["productDescription"].ToString();

                pnlProductContainer.Controls.Add(product);
            }
            SQLconnect.Close();
        }

        private void txtSearchImporter_TextChanged(object sender, EventArgs e)
        {
            SQLconnect.Close();
            //
            SQLconnect.Open();
            sqlCommand = new SqlCommand("SELECT * from tblImporter where importerName LIKE '%" + txtSearchImporter.Text + "%'", SQLconnect);
            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            DataSet dataSet = new DataSet();

            sqlDataAdapter.Fill(dataTable);
            pnlImporterContainer.Controls.Clear();
            for (int row = 0; row <= dataTable.Rows.Count - 1; row++)
            {
                UserControls.ctrlImporter importer = new UserControls.ctrlImporter();
                importer.lblImporter.Text = dataTable.Rows[row]["importerName"].ToString();
                importer.lblImporterID.Text = dataTable.Rows[row]["importerID"].ToString();

                pnlImporterContainer.Controls.Add(importer);
            }
            
            SQLconnect.Close();
        }

        private void btnClearImporter_Click(object sender, EventArgs e)
        {
            txtSearchImporter.Text = "";
        }
        public void importerAddEdit()
        {
            pnlImporter.Enabled = true;
            pnlSearchImporter.Enabled = false;
            pnlImporterContainer.Enabled = false;
            btnAddImporter.Visible = false;
            btnEditImporter.Visible = false;
            btnDeleteImporter.Visible = false;
            btnSaveImporter.Visible = true;
            btnCancelImporter.Visible = true;
        }
        public void exporterAddEdit()
        {
            pnlExporter.Enabled = true;
            pnlSearchExporter.Enabled = false;
            pnlExporterContainer.Enabled = false;
            btnAddExporter.Visible = false;
            btnEditExporter.Visible = false;
            btnDeleteExporter.Visible = false;
            btnSaveExporter.Visible = true;
            btnCancelExporter.Visible = true;
            pnlBranchMain.Enabled = false;
        }
        public void vesselAddEdit()
        {

            pnlVessel.Enabled = true;
            pnlSearchVessel.Enabled = false;
            pnlVesselContainer.Enabled = false;
            btnAddVessel.Visible = false;
            btnEditVessel.Visible = false;
            btnDeleteVessel.Visible = false;
            btnSaveVessel.Visible = true;
            btnCancelVessel.Visible = true;
        }
        private void btnAddImporter_Click(object sender, EventArgs e)
        {
  
            txtImporterName.Text = "";
            importerAddEdit();

            selectedbtn = 1;
        }

        private void btnEditImporter_Click(object sender, EventArgs e)
        {
            importerName = txtImporterName.Text;
       
            selectedbtn = 2;
            importerAddEdit();
        }

        private void btnDeleteImporter_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to delete this Importer?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                SQLconnect.Close();
                //
                sqlCommand = new SqlCommand("DELETE from tblImporter where importerID =" + txtImporterID.Text + " ", SQLconnect);

                SQLconnect.Open();
                try
                {
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }

                SQLconnect.Close();
                importers();
            }
        }

        private void btnSaveImporter_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedbtn == 1)
                {

                    if (txtImporterName.Text != "")
                    {
                        SQLconnect.Close();
                        //
                        sqlCommand = new SqlCommand("SELECT COUNT(*) from tblImporter where importerName = '" + txtImporterName.Text + "'", SQLconnect);

                        SQLconnect.Open();

                        Int32 count = (Int32)sqlCommand.ExecuteScalar();

                        SQLconnect.Close();
                        //MessageBox.Show(count.ToString());
                        if (count > 0)
                        {
                            MessageBox.Show("Importer already exist!");
                        }
                        else
                        {
                            SQLconnect.Close();
                            //
                            sqlCommand = new SqlCommand("INSERT INTO tblImporter (importerName) values('" + txtImporterName.Text + "')", SQLconnect);

                            SQLconnect.Open();

                            sqlCommand.ExecuteNonQuery();

                            SQLconnect.Close();
                            MessageBox.Show("Importer added successfully",
                            "Data Saved",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information,
                            MessageBoxDefaultButton.Button1);
                            importers();
                        }
                    }
                    else
                    {

                        MessageBox.Show("Importer details is incomplete",
                        "Data incomplete",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1);

                    }
                }
                if (selectedbtn == 2)
                {
                    if (txtImporterName.Text != "")
                    {
                        SQLconnect.Close();
                        //
                        sqlCommand = new SqlCommand("SELECT COUNT(*) from tblImporter where importerName = '" + txtImporterName.Text + "' and importerName <> '"+importerName+"'", SQLconnect);
                        // sqlCommand = new SqlCommand("SELECT COUNT(*) from tblProduct where hsCode = '" + txtHSCOde.Text + "' and hsCode <> '" + hsCode + "'", SQLconnect);
                        SQLconnect.Open();

                        Int32 count = (Int32)sqlCommand.ExecuteScalar();

                        SQLconnect.Close();
                        //MessageBox.Show(count.ToString());
                        if (count > 0)
                        {
                            MessageBox.Show("Importer already exist!");
                        }
                        else
                        {
                            SQLconnect.Close();
                            //
                            sqlCommand = new SqlCommand("Update tblImporter set importerName = '" + txtImporterName.Text + "' where importerID = " + txtImporterID.Text + " ", SQLconnect);

                            SQLconnect.Open();

                            sqlCommand.ExecuteNonQuery();

                            SQLconnect.Close();
                            MessageBox.Show("Importer updated successfully",
                            "Data Saved",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information,
                            MessageBoxDefaultButton.Button1);
                            importers();
                        }

                    }
                    else
                    {

                        MessageBox.Show("Importer details is incomplete",
                        "Data incomplete",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1);

                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void txtImporterID_TextChanged(object sender, EventArgs e)
        {
            btnEditImporter.Enabled = true;
            btnDeleteImporter.Enabled = true;
        }

        private void btnClearVessel_Click(object sender, EventArgs e)
        {
            txtSearchVessel.Text = "";
        }

        private void txtSearchVessel_TextChanged(object sender, EventArgs e)
        {
            SQLconnect.Close();
            //
            SQLconnect.Open();
            sqlCommand = new SqlCommand("SELECT * from tblVessel where vesselName LIKE '%" + txtSearchVessel.Text + "%'", SQLconnect);
            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            DataSet dataSet = new DataSet();

            sqlDataAdapter.Fill(dataTable);
            pnlVesselContainer.Controls.Clear();
            for (int row = 0; row <= dataTable.Rows.Count - 1; row++)
            {
                UserControls.ctrlVessels vessels = new UserControls.ctrlVessels();
                vessels.lblVesselName.Text = dataTable.Rows[row]["vesselName"].ToString();
                vessels.lblVesselID.Text = dataTable.Rows[row]["vesselID"].ToString();

                pnlVesselContainer.Controls.Add(vessels);
            }

            SQLconnect.Close();
        }

        private void txtVesselID_TextChanged(object sender, EventArgs e)
        {
            btnEditVessel.Enabled = true;
            btnDeleteVessel.Enabled = true;
        }

        private void btnAddVessel_Click(object sender, EventArgs e)
        {
        
            txtVesselName.Text = "";
            vesselAddEdit();

            selectedbtn = 1;
        }

        private void btnDeleteVessel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to delete this Vessel?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                SQLconnect.Close();
                //
                sqlCommand = new SqlCommand("DELETE from tblVessel where vesselID =" + txtVesselID.Text + " ", SQLconnect);

                SQLconnect.Open();
                try
                {
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }

                SQLconnect.Close();
                vessels();
            }
        }

        private void btnCancelVessel_Click(object sender, EventArgs e)
        {
            vessels();
        }

        private void btnSaveVessel_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (selectedbtn == 1)
                {

                    if (txtVesselName.Text != "")
                    {
                        SQLconnect.Close();
                        //
                        sqlCommand = new SqlCommand("SELECT COUNT(*) from tblVessel where vesselName = '" + txtVesselName.Text + "'", SQLconnect);

                        SQLconnect.Open();

                        Int32 count = (Int32)sqlCommand.ExecuteScalar();

                        SQLconnect.Close();
                        //MessageBox.Show(count.ToString());
                        if (count > 0)
                        {
                            MessageBox.Show("Vessel already exist!");
                        }
                        else
                        {
                            SQLconnect.Close();
                            //
                            sqlCommand = new SqlCommand("INSERT INTO tblVessel (VesselName) values('" + txtVesselName.Text + "')", SQLconnect);

                            SQLconnect.Open();

                            sqlCommand.ExecuteNonQuery();

                            SQLconnect.Close();
                            MessageBox.Show("Vessel added successfully",
                            "Data Saved",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information,
                            MessageBoxDefaultButton.Button1);
                            vessels();
                        }
                    }
                    else
                    {

                        MessageBox.Show("Vessel details is incomplete",
                        "Data incomplete",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1);

                    }
                }
                if (selectedbtn == 2)
                {
                    if (txtVesselName.Text != "")
                    {
                        SQLconnect.Close();
                        //
                        sqlCommand = new SqlCommand("SELECT COUNT(*) from tblVessel where vesselName = '" + txtVesselName.Text + "' and vesselName <> '" + vesselName + "'", SQLconnect);
                        // sqlCommand = new SqlCommand("SELECT COUNT(*) from tblProduct where hsCode = '" + txtHSCOde.Text + "' and hsCode <> '" + hsCode + "'", SQLconnect);
                        SQLconnect.Open();

                        Int32 count = (Int32)sqlCommand.ExecuteScalar();

                        SQLconnect.Close();
                        //MessageBox.Show(count.ToString());
                        if (count > 0)
                        {
                            MessageBox.Show("Vessel already exist!");
                        }
                        else
                        {
                            SQLconnect.Close();
                            //
                            sqlCommand = new SqlCommand("Update tblVessel set vesselName = '" + txtVesselName.Text + "' where vesselID = " + txtVesselID.Text + " ", SQLconnect);

                            SQLconnect.Open();

                            sqlCommand.ExecuteNonQuery();

                            SQLconnect.Close();
                            MessageBox.Show("Vessel updated successfully",
                            "Data Saved",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information,
                            MessageBoxDefaultButton.Button1);
                            vessels();
                        }

                    }
                    else
                    {

                        MessageBox.Show("Vessel details is incomplete",
                        "Data incomplete",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1);

                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
   
        }

        private void btnClearExporter_Click(object sender, EventArgs e)
        {
            txtSearchExporter.Text = "";
        }

        private void txtSearchExporter_TextChanged(object sender, EventArgs e)
        {
            SQLconnect.Close();
            //
            SQLconnect.Open();
            sqlCommand = new SqlCommand("SELECT * from tblExporter where exporterName LIKE '%" + txtSearchExporter.Text + "%'", SQLconnect);
            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            DataSet dataSet = new DataSet();

            sqlDataAdapter.Fill(dataTable);
            pnlExporterContainer.Controls.Clear();
            for (int row = 0; row <= dataTable.Rows.Count - 1; row++)
            {
                UserControls.ctrlExporter exporter = new UserControls.ctrlExporter();
                exporter.lblExporter.Text = dataTable.Rows[row]["exporterName"].ToString();
                exporter.lblExporterID.Text = dataTable.Rows[row]["exporterID"].ToString();

                pnlExporterContainer.Controls.Add(exporter);
            }

            SQLconnect.Close();
        }

        private void txtExporterID_TextChanged(object sender, EventArgs e)
        {
            btnEditExporter.Enabled = true;
            btnDeleteExporter.Enabled = true;

            txtBranchAddress.Text = "";
            txtBranchID.Text = "";
            if (txtExporterID.Text != "")
            {
                
               
                SQLconnect.Close();
                //
                SQLconnect.Open();

                sqlCommand = new SqlCommand("SELECT * from tblExporterBranch where exporterID = " + txtExporterID.Text + "", SQLconnect);
                sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                DataSet dataSet = new DataSet();
                //MessageBox.Show(txtExporterID.Text);
                sqlDataAdapter.Fill(dataTable);
                pnlExporterBranchContainer.Controls.Clear();
                for (int row = 0; row <= dataTable.Rows.Count - 1; row++)
                {
                    UserControls.ctrlExporterBranch exporterBranch = new UserControls.ctrlExporterBranch();
                    exporterBranch.lblExporterBranch.Text = dataTable.Rows[row]["exporterAddress"].ToString();
                    exporterBranch.lblExporterBranchID.Text = dataTable.Rows[row]["exporterBranchID"].ToString();

                    pnlExporterBranchContainer.Controls.Add(exporterBranch);
                }

                SQLconnect.Close();

            }
            
            
        }

        private void btnAddExporter_Click(object sender, EventArgs e)
        {
            txtExporterName.Text = "";
            exporterAddEdit();

            selectedbtn = 1;

        }

        private void btnDeleteExporter_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to delete this Company and its branches?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                SQLconnect.Close();
                //
                sqlCommand = new SqlCommand("DELETE from tblExporter where exporterID =" + txtExporterID.Text + " ", SQLconnect);

                SQLconnect.Open();
                try
                {
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }

                SQLconnect.Close();
                //
                sqlCommand = new SqlCommand("DELETE from tblExporterBranch where exporterID =" + txtExporterID.Text + " ", SQLconnect);

                SQLconnect.Open();
                try
                {
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }

                SQLconnect.Close();
                exporters();
            }
        }

        private void btnCancelExporter_Click(object sender, EventArgs e)
        {
            exporters();
            
        }

        private void btnAddBranch_Click(object sender, EventArgs e)
        {
            if (txtExporterID.Text != "" && txtExporterName.Text != "")
            {

                txtBranchAddress.Text = "";
                branchAddEdit();

                selectedbtn = 1;
            }
            else
            {
                MessageBox.Show("Please select company first before adding branch address");
            }
            
        }

        private void btnEditBranch_Click(object sender, EventArgs e)
        {
            if (txtBranchID.Text != "" && txtBranchAddress.Text != "")
            {
                exporterAddress = txtBranchAddress.Text;
                
                selectedbtn = 2;
                branchAddEdit();
            }
            else
            {
                MessageBox.Show("Please select branch address to edit");
            }
        }

        private void btnSaveBranch_Click(object sender, EventArgs e)
        {
            
            
            try
            {
                if (selectedbtn == 1)
                {

                    if (txtBranchAddress.Text != "")
                    {
                        SQLconnect.Close();
                        //
                        sqlCommand = new SqlCommand("SELECT COUNT(*) from tblExporterBranch where exporterAddress = '" + txtBranchAddress.Text + "' and exporterID = "+txtExporterID.Text+"", SQLconnect);

                        SQLconnect.Open();

                        Int32 count = (Int32)sqlCommand.ExecuteScalar();

                        SQLconnect.Close();
                        //MessageBox.Show(count.ToString());
                        if (count > 0)
                        {
                            MessageBox.Show("Address already exist!");
                        }
                        else
                        {
                            SQLconnect.Close();
                            //
                            sqlCommand = new SqlCommand("INSERT INTO tblExporterBranch (exporterAddress, exporterID) values('" + txtBranchAddress.Text + "', "+txtExporterID.Text+")", SQLconnect);

                            SQLconnect.Open();

                            sqlCommand.ExecuteNonQuery();

                            SQLconnect.Close();
                            MessageBox.Show("Branch added successfully",
                            "Data Saved",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information,
                            MessageBoxDefaultButton.Button1);
                            branchRefresh();
                        }
                    }
                    else
                    {

                        MessageBox.Show("Branch details is incomplete",
                        "Data incomplete",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1);

                    }
                }
                if (selectedbtn == 2)
                {
                    if (txtExporterName.Text != "")
                    {
                        SQLconnect.Close();
                        //
                        sqlCommand = new SqlCommand("SELECT COUNT(*) from tblExporterBranch where exporterAddress = '" + txtBranchAddress.Text + "' and exporterAddress <> '" + exporterAddress + "' and exporterID = " + txtExporterID.Text + "", SQLconnect);
                        // sqlCommand = new SqlCommand("SELECT COUNT(*) from tblProduct where hsCode = '" + txtHSCOde.Text + "' and hsCode <> '" + hsCode + "'", SQLconnect);
                        SQLconnect.Open();

                        Int32 count = (Int32)sqlCommand.ExecuteScalar();

                        SQLconnect.Close();
                        //MessageBox.Show(count.ToString());
                        if (count > 0)
                        {
                            MessageBox.Show("Address already exist!");
                        }
                        else
                        {
                            SQLconnect.Close();
                            //
                            sqlCommand = new SqlCommand("Update tblExporterBranch set exporterAddress = '" + txtBranchAddress.Text + "' where exporterBranchID = " + txtBranchID.Text + " ", SQLconnect);

                            SQLconnect.Open();

                            sqlCommand.ExecuteNonQuery();

                            SQLconnect.Close();
                            MessageBox.Show("Branch updated successfully",
                            "Data Saved",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information,
                            MessageBoxDefaultButton.Button1);
                            branchRefresh(); //exporters();
                        }

                    }
                    else
                    {

                        MessageBox.Show("Branch details is incomplete",
                        "Data incomplete",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1);

                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }


        private void btnCancelBranch_Click(object sender, EventArgs e)
        {
            branchRefresh();
        }

        private void branchAddEdit()
        {

            pnlExporterMain.Enabled = false;
            pnlExporterContainer.Enabled = false;
            pnlSearchExporter.Enabled = false;
            pnlBranchMain.Enabled = true;

            pnlBranch.Enabled = true;
            pnlExporterBranchContainer.Enabled = false;
  
            btnAddBranch.Visible = false;
            btnEditBranch.Visible = false;
            btnDeleteBranch.Visible = false;
            btnSaveBranch.Visible = true;
            btnCancelBranch.Visible = true;

        }
        private void branchRefresh()
        {
           

            if (txtExporterID.Text != "")
            {


                SQLconnect.Close();
                //
                SQLconnect.Open();

                sqlCommand = new SqlCommand("SELECT * from tblExporterBranch where exporterID = " + txtExporterID.Text + "", SQLconnect);
                sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                DataSet dataSet = new DataSet();
                //MessageBox.Show(txtExporterID.Text);
                sqlDataAdapter.Fill(dataTable);
                pnlExporterBranchContainer.Controls.Clear();
                for (int row = 0; row <= dataTable.Rows.Count - 1; row++)
                {
                    UserControls.ctrlExporterBranch exporterBranch = new UserControls.ctrlExporterBranch();
                    exporterBranch.lblExporterBranch.Text = dataTable.Rows[row]["exporterAddress"].ToString();
                    exporterBranch.lblExporterBranchID.Text = dataTable.Rows[row]["exporterBranchID"].ToString();

                    pnlExporterBranchContainer.Controls.Add(exporterBranch);
                }

                SQLconnect.Close();

                btnAddBranch.Visible = true;
                btnEditBranch.Visible = false;
                btnDeleteBranch.Visible = false;
                btnSaveBranch.Visible = false;
                btnCancelBranch.Visible = false;
                pnlBranch.Enabled = false;
                pnlExporterBranchContainer.Enabled = true;

                pnlExporterMain.Enabled = true;
                pnlExporterContainer.Enabled = true;
                pnlSearchExporter.Enabled = true;
                txtBranchID.Text = "";
                txtBranchAddress.Text = "";

            }

        }
        private void btnDeleteBranch_Click(object sender, EventArgs e)
        {
            if (txtBranchID.Text != "" && txtBranchAddress.Text != "")
            {
                DialogResult result = MessageBox.Show("Are you sure to delete this branch?", "Warning",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    SQLconnect.Close();
                    //
                    sqlCommand = new SqlCommand("DELETE from tblExporterBranch where exporterBranchID =" + txtBranchID.Text + " ", SQLconnect);

                    SQLconnect.Open();
                    try
                    {
                        sqlCommand.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.ToString());
                    }

                    SQLconnect.Close();

                    //exporters();
                    branchRefresh();

                }
            }
            else
            {
                MessageBox.Show("Please select branch address to delete");
            }
        }

        private void txtBranchID_TextChanged(object sender, EventArgs e)
        {


        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialRadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void materialRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtProductSelection_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void materialLabel27_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            


        }

        private void btnAddProdList_Click(object sender, EventArgs e)
        {
            UserControls.ctrlProductSearch ProdList = new UserControls.ctrlProductSearch();
            pnlProductListContainer.Controls.Add(ProdList);

        }

        private void cboTransExporter_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cboTransExporter_SelectedValueChanged(object sender, EventArgs e)
        {
           
            //MessageBox.Show(cboTransExporter.SelectedValue.ToString());

        }

        private void cboStandard_SelectedValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cboStandard.SelectedItem.ToString());
            //MessageBox.Show(cboStandard.SelectedValue.ToString());
        }

        private void lblTransID_TextChanged(object sender, EventArgs e)
        {
           
         
            

        }
        public void transactionClear()
        {

        }
        public void totalNetGross()
        {
            try
            {
                Decimal net = 0, gross = 0, volume=0;
                foreach (Control controlVariable in pnlProductListContainer.Controls)
                {
                    if (controlVariable is UserControls.ctrlProductSearch)
                    {

                        TextBox txtNet = (TextBox)controlVariable.Controls["txtNet"];

                        TextBox txtGross = (TextBox)controlVariable.Controls["txtGross"];

                        TextBox txtVolume = (TextBox)controlVariable.Controls["txtVolume"];

                        //string moneyValue = String.Format("{0:C}", moneyvalue);
                        net = net + System.Convert.ToDecimal(txtNet.Text);
                        gross = gross + System.Convert.ToDecimal(txtGross.Text);
                        volume = volume + System.Convert.ToDecimal(txtVolume.Text);
                        //gross = gross + float.Parse(txtGross.ToString());
                        //MessageBox.Show(txtHSCODE.Text);
                    }

                }
                lblGross.Text = String.Format("{0:C}", gross);
                lblNet.Text = String.Format("{0:C}", net);
                lblVolume.Text = String.Format("{0:N}", volume) + " Kg.";

            }
            catch (Exception ex)
            {

                //MessageBox.Show(ex.ToString());
            }
        }
        public void newTransaction()
        {
            dtpTrans.Text = "";
            cboStandard.Text = "";
            txtTransDecNum.Text = "";
            radAir.Checked = false;
            radSea.Checked = false;
            cboTransExporter.Text = "";
            
            cboTransImporter.Text = "";
            txtPort.Text = "";
            cboTransDestination.Text = "";
            pnlProductListContainer.Controls.Clear();
            //UserControls.ctrlProductSearch ProdList = new UserControls.ctrlProductSearch();
            //pnlProductListContainer.Controls.Add(ProdList);
            chkWithCO.Checked = false;
            txtTransOriginCriterion.Text = "";
            txtTransRemarks.Text = "";
            txtTransCoRefer.Text = "";
            cboTransVessel.Text = "";
            txtVoyageNum.Text = "";
            txtATL.Text = "";
            cboTransExaminer.Text = "";
            lblVolume.Text = "0 Kg.";
            lblNet.Text = "$0.00";
            lblGross.Text = "$0.00";
        }
        private void btnNewTransaction_Click(object sender, EventArgs e)
        {

            newTransaction();
            btnSaveTransaction.Visible = true;
            btnCancelTransaction2.Visible = true;
            btnCancelTransaction.Visible = false;
            pnlTransMain.Visible = true;


        }

        private void cboTransExporter_ValueMemberChanged(object sender, EventArgs e)
        {
           
        }

        private void cboTransExporter_Leave(object sender, EventArgs e)
        {
           
        }

        private void cboTransExporter_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            



        }

        private void btnCancelTransaction2_Click(object sender, EventArgs e)
        {
            transactions();
        }

        private void btnCancelTransaction_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to  cancel this transaction?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                SQLconnect.Close();
                //
                sqlCommand = new SqlCommand("Update tblTransaction set statusID = 2 where transID = " + lblTransID.Text + " ", SQLconnect);

                SQLconnect.Open();

                sqlCommand.ExecuteNonQuery();

                SQLconnect.Close();
                MessageBox.Show("Transaction saved successfully",
                "Data Saved",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
                transactions();
            }
            
        }

        private void cboStandard_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void txtTransStandard_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void cboStandard_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtSearchTransactions_TextChanged(object sender, EventArgs e)
        {
            SQLconnect.Close();

            SQLconnect.Open();
            

            sqlCommand = new SqlCommand("SELECT *  from tblTransaction where transDate LIKE '%" + txtSearchTransactions.Text + "%' or transDeclarationNum LIKE '%" + txtSearchTransactions.Text + "%'", SQLconnect);
            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            DataSet dataSet = new DataSet();

            sqlDataAdapter.Fill(dataTable);
            pnlTransContainer.Controls.Clear();
            for (int row = 0; row <= dataTable.Rows.Count - 1; row++)
            {
                UserControls.ctrlTrans trans = new UserControls.ctrlTrans();
                trans.lblTransID.Text = dataTable.Rows[row]["transID"].ToString();
                //DateTime dt = System.DateTime.Parse(dataTable.Rows[row]["transDate"].ToString());
                ////////DateTime dt = System.DateTime.Parse(dataTable.Rows[row]["transDate"].ToString());
                ///////////trans.dtpTransDate.Value = dt;//dtpTrans.Value.Date.ToString("yyyyMMdd") 
                //trans.dtpTransDate.Value = dataTable.Rows[row]["transDate"].ToString(yyyyMMdd);
                //trans.lblTransDate.Text = dataTable.Rows[row]["transDate"].ToString("yyyyMMdd"); //
                //////////
                trans.lblTransDate.Text = dataTable.Rows[row]["transDate"].ToString();

                //trans.dtpTransDate.Value = dt;
                trans.lblTransDeclarationNum.Text = dataTable.Rows[row]["transDeclarationNum"].ToString();
                trans.lblStandard.Text = dataTable.Rows[row]["transStandardID"].ToString();
                trans.lblEportType.Text = dataTable.Rows[row]["exportTypeID"].ToString();
                trans.lblBranchAddress.Text = dataTable.Rows[row]["exporterBranchID"].ToString();
                trans.lblTransImporter.Text = dataTable.Rows[row]["importerID"].ToString();
                trans.lblPort.Text = dataTable.Rows[row]["portOrigin"].ToString();
                trans.lbldestination.Text = dataTable.Rows[row]["destinationID"].ToString();
                trans.lblWithCO.Text = dataTable.Rows[row]["withCO"].ToString();
                trans.lblOriginCriterion.Text = dataTable.Rows[row]["originCriterion"].ToString();
                trans.lblRemarks.Text = dataTable.Rows[row]["remarks"].ToString();
                trans.lblCoReferenceNum.Text = dataTable.Rows[row]["coReferenceNum"].ToString();
                trans.lblVoyageNum.Text = dataTable.Rows[row]["voyageNum"].ToString();
                trans.lblATL.Text = dataTable.Rows[row]["atl"].ToString();

                trans.lblVessel.Text = dataTable.Rows[row]["vesselID"].ToString();
                trans.lblExaminer.Text = dataTable.Rows[row]["examinerID"].ToString();
                trans.lblStatus.Text = dataTable.Rows[row]["statusID"].ToString();

                pnlTransContainer.Controls.Add(trans);
            }
            SQLconnect.Close();

        }

        private void btnClearSearchTransactions_Click(object sender, EventArgs e)
        {
            txtSearchTransactions.Text = "";

        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchUser_TextChanged(object sender, EventArgs e)
        {
            SQLconnect.Close();
            ////
            SQLconnect.Open();
            sqlCommand = new SqlCommand("SELECT * from tblUser where username LIKE '%" + txtSearchUser.Text + "%'", SQLconnect);
            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            DataSet dataSet = new DataSet();

            sqlDataAdapter.Fill(dataTable);
            pnlUserContainer.Controls.Clear();
            for (int row = 0; row <= dataTable.Rows.Count - 1; row++)
            {
                UserControls.ctrlUsers user = new UserControls.ctrlUsers();
                user.lblUserID.Text = dataTable.Rows[row]["userID"].ToString();
                user.lblUsername.Text = dataTable.Rows[row]["username"].ToString();
                user.lblPassword.Text = dataTable.Rows[row]["password"].ToString();
                user.lblAdminControl.Text = dataTable.Rows[row]["adminControl"].ToString();

                pnlUserContainer.Controls.Add(user);
            }
            SQLconnect.Close();
        }

        private void btnlClearUserSearch_Click(object sender, EventArgs e)
        {
            txtSearchUser.Text = "";
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";

            userAddEdit();


            selectedbtn = 1;
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to delete this user?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                SQLconnect.Close();
                //
                sqlCommand = new SqlCommand("DELETE from tblUser where userID =" + txtUserID.Text + " ", SQLconnect);

                SQLconnect.Open();
                try
                {
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }

                SQLconnect.Close();
                users();
            }
        }

        private void btnCancelUser_Click(object sender, EventArgs e)
        {
            users();
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedbtn == 1)
                {

                    if (txtUsername.Text != "" && txtPassword.Text != "")
                    {
                        SQLconnect.Close();
                        //
                        sqlCommand = new SqlCommand("SELECT COUNT(*) from tblUser where username = '" + txtUsername.Text + "'", SQLconnect);

                        SQLconnect.Open();

                        Int32 count = (Int32)sqlCommand.ExecuteScalar();

                        SQLconnect.Close();
                        //MessageBox.Show(count.ToString());
                        if (count > 0)
                        {
                            MessageBox.Show("username already exist!");
                        }
                        else
                        {
                            SQLconnect.Close();
                            //
                            if(chkAdmin.Checked == true)
                            {
                                sqlCommand = new SqlCommand("INSERT INTO tblUser (username, password, adminControl) values('" + txtUsername.Text + "','" + txtPassword.Text + "', 1)", SQLconnect);

                            }
                            if (chkAdmin.Checked == false)
                            {
                                sqlCommand = new SqlCommand("INSERT INTO tblUser (username, password, adminControl) values('" + txtUsername.Text + "','" + txtPassword.Text + "', 0)", SQLconnect);

                            }
                            SQLconnect.Open();

                            sqlCommand.ExecuteNonQuery();

                            SQLconnect.Close();
                            MessageBox.Show("user added successfully",
                            "Data Saved",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information,
                            MessageBoxDefaultButton.Button1);
                            users();
                        }
                    }
                    else
                    {

                        MessageBox.Show("User details is incomplete",
                        "Data incomplete",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1);

                    }
                }
                if (selectedbtn == 2)
                {
                    if (txtUsername.Text != "" && txtPassword.Text != "")
                    {
                        SQLconnect.Close();
                        //
                        sqlCommand = new SqlCommand("SELECT COUNT(*) from tblUser where username = '" + txtUsername.Text + "' and username <> '" + username + "'", SQLconnect);

                        SQLconnect.Open();

                        Int32 count = (Int32)sqlCommand.ExecuteScalar();

                        SQLconnect.Close();
                        //MessageBox.Show(count.ToString());
                        if (count > 0)
                        {
                            MessageBox.Show("username already exist!");
                        }
                        else
                        {
                            SQLconnect.Close();
                            //
                            if (chkAdmin.Checked == false)
                            { 
                                sqlCommand = new SqlCommand("Update tblUser set username = '" + txtUsername.Text + "', password = '" + txtPassword.Text + "', adminControl = 0 where userID = " + txtUserID.Text + " ", SQLconnect);
                            }
                            if (chkAdmin.Checked == true)
                            {
                                sqlCommand = new SqlCommand("Update tblUser set username = '" + txtUsername.Text + "', password = '" + txtPassword.Text + "', adminControl = 1 where userID = " + txtUserID.Text + " ", SQLconnect);
                            }
                            SQLconnect.Open();

                            sqlCommand.ExecuteNonQuery();

                            SQLconnect.Close();
                            MessageBox.Show("user updated successfully",
                            "Data Saved",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information,
                            MessageBoxDefaultButton.Button1);
                            users();
                        }

                    }
                    else
                    {

                        MessageBox.Show("User details is incomplete",
                        "Data incomplete",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1);

                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void txtSearchExaminer_TextChanged(object sender, EventArgs e)
        {
            SQLconnect.Close();
            ////
            SQLconnect.Open();
            sqlCommand = new SqlCommand("SELECT * from tblExaminer where firstname LIKE '%" + txtSearchExaminer.Text + "%' or lastname LIKE '%" + txtSearchExaminer.Text + "%' or mi LIKE '%" + txtSearchExaminer.Text + "%' ", SQLconnect);
            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            DataSet dataSet = new DataSet();

            sqlDataAdapter.Fill(dataTable);
            pnlExaminerContainer.Controls.Clear();
            for (int row = 0; row <= dataTable.Rows.Count - 1; row++)
            {
                UserControls.ctrlExaminer examiner = new UserControls.ctrlExaminer();
                examiner.lblExaminerID.Text = dataTable.Rows[row]["examinerID"].ToString();
                examiner.lblFirstname.Text = dataTable.Rows[row]["firstname"].ToString();
                examiner.lblMI.Text = dataTable.Rows[row]["mi"].ToString();
                examiner.lblLastname.Text = dataTable.Rows[row]["lastname"].ToString();
                examiner.lblFullname.Text = examiner.lblLastname.Text + ", " + examiner.lblFirstname.Text + " " + examiner.lblMI.Text;

                pnlExaminerContainer.Controls.Add(examiner);
            }
            SQLconnect.Close();
        }

        private void btnClearSearchExaminer_Click(object sender, EventArgs e)
        {
            txtSearchExaminer.Text = "";
        }

        private void btnAddExaminer_Click(object sender, EventArgs e)
        {
            txtUserID.Text = "";
            txtFirstname.Text = "";
            txtLastname.Text = "";
            txtMI.Text = "";

            examinerAddEdit();


            selectedbtn = 1;
        }

        private void btnEditExaminer_Click(object sender, EventArgs e)
        {
            firstname = txtFirstname.Text;
            mi = txtMI.Text;
            lastname = txtLastname.Text;
            examinerAddEdit();
            selectedbtn = 2;
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            //formLogin login = new formLogin();
            
            //MessageBox.Show("Welcome " + formLogin.txtUsername.Text);
        }
        //LBLUSERNAME.Text = ; txtbox2.Text =

        private void formMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void formMain_Shown(object sender, EventArgs e)
        {

            var form = new formLogin();

            //lblUserIDLogin.Text = "Welcome " + lblUserIDLogin.Text;
            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //ReportViewer rpt = new ReportViewer();
            ReportViewer rpt = new ReportViewer();


            rpt.reportViewer1.Visible = true;
            //rpt.reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
            rpt.reportViewer1.LocalReport.DataSources.Clear();
            if (rptEx == 1)
            {
                rpt.reportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory + "\\Reports\\ReportTopExportDestination.rdlc";
                rpt.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsReportTopExportDestination", dataTable));
                List<ReportParameter> paramList = new List<ReportParameter>();

                paramList.Add(new ReportParameter("paramDateFrom", dtpFrom.Text, true));
                paramList.Add(new ReportParameter("paramDateTo", dtpTo.Value.ToString("d", CultureInfo.CreateSpecificCulture("en-US")), true));
                rpt.reportViewer1.LocalReport.SetParameters(paramList);
                rpt.reportViewer1.RefreshReport();
                rpt.ShowDialog();
            }
            if (rptEx == 2)
            {
                rpt.reportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory + "\\Reports\\ReportTopExporCommodity.rdlc";
                rpt.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsExportCommodity", dataTable));
                List<ReportParameter> paramList = new List<ReportParameter>();

                paramList.Add(new ReportParameter("paramDateFrom", dtpFrom.Text, true));
                paramList.Add(new ReportParameter("paramDateTo", dtpTo.Value.ToString("d", CultureInfo.CreateSpecificCulture("en-US")), true));
                rpt.reportViewer1.LocalReport.SetParameters(paramList);
                rpt.reportViewer1.RefreshReport();
                rpt.ShowDialog();
            }
            if (rptEx == 3)
            {
                rpt.reportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory + "\\Reports\\ReportTopExporter.rdlc";
                rpt.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsTopExporter", dataTable));
                List<ReportParameter> paramList = new List<ReportParameter>();
                paramList.Add(new ReportParameter("paramDateFrom", dtpFrom.Text, true));
                paramList.Add(new ReportParameter("paramDateTo", dtpTo.Value.ToString("d", CultureInfo.CreateSpecificCulture("en-US")), true));
                rpt.reportViewer1.LocalReport.SetParameters(paramList);
                rpt.reportViewer1.RefreshReport();
                rpt.ShowDialog();

            }
            if (rptEx == 4)
            {
                rpt.reportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory + "\\Reports\\ReportExportDeclarationWithCo.rdlc";
                string qry = "SELECT tblTransaction.transID, tblTransaction.transDeclarationNum , " +
                         "tblExporter.exporterName,  " +
                         "tblImporter.importerName , " +
                         "tblTransaction.portOrigin ,  " +
                         "tblDestination.destinationName , " +
                         "tblProduct.hsCode , " +
                        "  tblProduct.productDescription , " +
                           "tblTransaction.originCriterion , " +
                           "tblTransaction.remarks , " +
                           "tblTransaction.coReferenceNum, " +
                        "	tblDestination.FTA , tblTransProductList.net " +
                        "FROM tblTransaction " +
                        "INNER JOIN tblTransProductList on tblTransaction.transID = tblTransProductList.transID " +
                        "INNER JOIN tblProduct on tblTransProductList.productID = tblProduct.productID " +
                        "INNER JOIN tblExporterBranch on tblTransaction.exporterBranchID = tblExporterBranch.exporterBranchID " +
                        "INNer join tblExporter on tblExporterBranch.exporterID = tblExporter.exporterID " +
                        "Inner join tblImporter on tblImporter.importerID = tblTransaction.importerID " +
                        "INNER JOIN tblDestination on tblDestination.destinationID = tblTransaction.destinationID " +
                           "WHERE tblTransaction.withCO = 1 and tblTransaction.transDate between '" + dtpFrom.Text + "' and  '" + dtpTo.Text + "' ";

                SQLconnect.Close();
                SQLconnect.ConnectionString = conStr;
                SQLconnect.Open();

                sqlCommand = new SqlCommand(qry, SQLconnect);
                sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                dataTable = new DataTable();


                sqlDataAdapter.Fill(dataTable);

                rpt.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsWithCo", dataTable));
                List<ReportParameter> paramList = new List<ReportParameter>();
                paramList.Add(new ReportParameter("paramDateFrom", dtpFrom.Text, true));
                paramList.Add(new ReportParameter("paramDateTo", dtpTo.Value.ToString("d", CultureInfo.CreateSpecificCulture("en-US")), true));
                rpt.reportViewer1.LocalReport.SetParameters(paramList);
                rpt.reportViewer1.RefreshReport();
                rpt.ShowDialog();
            }
            if (rptEx == 5)
            {
                rpt.reportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory + "\\Reports\\ReportExportDeclarationWithoutCo.rdlc";
                string qry = "SELECT tblTransaction.transDeclarationNum, " +
                             "tblExporter.exporterName, " +
                            "tblImporter.importerName, " +
                            "tblTransaction.portOrigin, " +
                            "tblDestination.destinationName, " +
                            "tblProduct.hsCode, " +
                            "tblProduct.productDescription, " +
                            "tblTransProductList.net " +
                            "FROM tblTransaction " +
                            "INNER JOIN tblImporter on tblTransaction.importerID = tblTransaction.importerID " +
                            "INNER JOIN tblExporterBranch on tblExporterBranch.exporterBranchID = tblTransaction.exporterBranchID " +
                            "INNER JOIN tblExporter on tblExporter.exporterID = tblExporterBranch.exporterBranchID " +
                            "INNER JOIN tblDestination on tblDestination.destinationID = tblTransaction.destinationID " +
                            "INNER JOIN tblTransProductList on tblTransProductList.transID = tblTransaction.transID " +
                            "INNER jOIN tblProduct on tblProduct.productID = tblTransProductList.productID " +
                            "WHERE tblTransaction.withCO = 0 and tblTransaction.transDate between '" + dtpFrom.Text + "' and  '" + dtpTo.Text + "' ";
                SQLconnect.Close();
                SQLconnect.ConnectionString = conStr;
                SQLconnect.Open();

                sqlCommand = new SqlCommand(qry, SQLconnect);
                sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                dataTable = new DataTable();


                sqlDataAdapter.Fill(dataTable);
                rpt.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsWithoutCo", dataTable));
                List<ReportParameter> paramList = new List<ReportParameter>();
                paramList.Add(new ReportParameter("paramDateFrom", dtpFrom.Text, true));
                paramList.Add(new ReportParameter("paramDateTo", dtpTo.Value.ToString("d", CultureInfo.CreateSpecificCulture("en-US")), true));
                rpt.reportViewer1.LocalReport.SetParameters(paramList);
                rpt.reportViewer1.RefreshReport();
                rpt.ShowDialog();

            }
        }

        private void pnlExDes_Click(object sender, EventArgs e)
        {
            enableReportBtn(true);
            // pnlExDes.Enabled = false;
            lblTopExDes.ForeColor = Color.Teal;
            pnlLeftTopExportDes.BackColor = Color.Teal;
            rptEx = 1;
            ExDes();
        }

        private void pnlExCom_Click(object sender, EventArgs e)
        {
            enableReportBtn(true);
            // pnlExCom.Enabled = false;
            lblTopExCom.ForeColor = Color.Teal;
            pnlLeftTopExCom.BackColor = Color.Teal;
            rptEx = 2;
            ExCom();

        }

        private void pnlEx_Click(object sender, EventArgs e)
        {
            enableReportBtn(true);
            //pnlEx.Enabled = false;
            pnlLeftTopEx.BackColor = Color.Teal;
            lblTopEx.ForeColor = Color.Teal;
            rptEx = 3;
            Ex();
        }

        private void pnlExCo_Click(object sender, EventArgs e)
        {
            enableReportBtn(true);
            //pnlEx.Enabled = false;
            pnlLeftExCo.BackColor = Color.Teal;
            lblExCo.ForeColor = Color.Teal;
            rptEx = 4;
            WitCo();
        }

        private void pnlExWCo_Click(object sender, EventArgs e)
        {
            enableReportBtn(true);
            //pnlEx.Enabled = false;
            pnlLeftExWCo.BackColor = Color.Teal;
            lblExWCo.ForeColor = Color.Teal;
            rptEx = 5;
            withOutCo();
        }

        private void pnlExWCo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlStats_Click(object sender, EventArgs e)
        {
            enableReportBtn(true);
            //pnlEx.Enabled = false;
            pnlLeftStats.BackColor = Color.Teal;
            lblStats.ForeColor = Color.Teal;
            rptEx = 6;
            stats();
        }

        private void lblStats_Click(object sender, EventArgs e)
        {
            enableReportBtn(true);
            //pnlEx.Enabled = false;
            pnlLeftStats.BackColor = Color.Teal;
            lblStats.ForeColor = Color.Teal;
            rptEx = 6;
            stats();
        }
        public void qryReports(string qry)
        {
            SQLconnect.Close();
            SQLconnect.ConnectionString = conStr;
            SQLconnect.Open();

            sqlCommand = new SqlCommand(qry, SQLconnect);
            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            dataTable = new DataTable();


            sqlDataAdapter.Fill(dataTable);



            grdTop.DataSource = dataTable;

        }
        public void enableReportBtn(bool ctr)
        {
            //pnlEx.Enabled = ctr;
            //pnlExCom.Enabled = ctr;
            //pnlExDes.Enabled = ctr;
            pnlLeftTopEx.BackColor = Color.White;
            pnlLeftTopExCom.BackColor = Color.White;
            pnlLeftTopExportDes.BackColor = Color.White;
            pnlLeftExCo.BackColor = Color.White;
            pnlLeftExWCo.BackColor = Color.White;
            pnlLeftStats.BackColor = Color.White;
            lblTopExDes.ForeColor = Color.Black;
            lblTopExCom.ForeColor = Color.Black;
            lblTopEx.ForeColor = Color.Black;
            lblExCo.ForeColor = Color.Black;
            lblExWCo.ForeColor = Color.Black;
            lblStats.ForeColor = Color.Black;

        }
        public void ExDes()
        {

            string qry = "Select destinationName, " +

                    "STUFF((SELECT DISTINCT ', ' + productDescription " +
                    "             FROM tblProduct t " +
                    "              inner join tblTransProductList f on t.productID = f.productID " +
                                  "inner join tblTransaction g on f.transID = g.transID " +
                                  "INNER JOIN tblDestination h on g.destinationID = h.destinationID             " +
                                  "where h.destinationName = e.destinationName and g.transDate between '" + dtpFrom.Text + "' and  '" + dtpTo.Text + "' " +
                                  "FOR XML PATH('')), 1, 1, '') Commodity, " +
                    "SUm(c.volume) as Volume, " +
                    "SUM(c.net) as Net, " +
                    "SUM(c.gross) as Gross " +
                    "From tblTransaction d " +
                    "INNER JOIN tblDestination e on d.destinationID = e.destinationID " +
                    "INNER JOIN tblTransProductList c on d.transID = c.transID " +
                    "INNER JOIN tblProduct on c.productID = tblProduct.productID " +
                    "Where d.transDate between '" + dtpFrom.Text + "' and  '" + dtpTo.Text + "' " +
                    "GROUP BY destinationName ORDER BY GROSS DESC";

            qryReports(qry);
        }

        public void ExCom()
        {
            string qry = "SELECT tbp2.productDescription as Commodites,  " +
                   "(STUFF((SELECT DISTINCT', ' + tbd.destinationName " +
                   "FROM tblDestination tbd " +
                   "INNER JOIN tblTransaction tbt on tbd.destinationID = tbt.destinationID " +
                   "INNER JOIN tblTransProductList tbtl on tbtl.transID = tbt.transID " +
                   "INNER JOIN tblProduct tbp on tbp.productID = tbtl.productID " +
                   "WHERE tbp.productDescription = tbp2.productDescription AND tbt.transDate between '" + dtpFrom.Text + "' and  '" + dtpTo.Text + "' " +
                   "FOR XML PATH('')), 1, 2, '') ) AS Destinations, " +
                   "sum(tblTransProductList.volume) as Volume ,sum(tblTransProductList.net) as Net, sum(tblTransProductList.gross) as Gross " +
                   "FROM tblTransaction " +
                   "INNER JOIN tblTransProductList on tblTransaction.transID = tblTransProductList.transID " +
                   "INNer JOIN tblProduct tbp2 on tblTransProductList.productID = tbp2.productID " +
                   "INNer join tblDestination on tblTransaction.destinationID = tblDestination.destinationID " +
                   "Where tblTransaction.transDate between '" + dtpFrom.Text + "' and  '" + dtpTo.Text + "' " +
                   "Group by  tbp2.productDescription " +
                   "ORDER by Gross desc ";


            qryReports(qry);
        }

        public void Ex()
        {
            string qry = "select a.exporterName, " +
                       "(STUFF((SELECT DISTINCT', ' + tblProduct.productDescription " +
                        "FROM tblProduct " +
                        "INNER JOIN tblTransProductList on tblTransProductList.productID = tblProduct.productID " +
                        "INNER JOIN tblTransaction on tblTransProductList.transID = tblTransaction.transID " +
                        "INNER JOIN tblExporterBranch on tblExporterBranch.exporterBranchID = tblTransaction.exporterBranchID " +
                        "INNER JOIN tblExporter b on b.exporterID = tblExporterBranch.exporterID " +
                        "WHERE b.exporterName = a.exporterName AND tblTransaction.transDate  between '" + dtpFrom.Text + "' and  '" + dtpTo.Text + "' " +
                        "FOR XML PATH('')), 1, 2, '')    ) AS Commodities, " +
                       "SUM(tblTransProductList.volume)as Volume, sum(tblTransProductList.net) as Net,sum(tblTransProductList.gross) as Gross " +
                        "from tblTransaction " +
                        "INNER JOIN tblExporterBranch on tblTransaction.exporterBranchID = tblExporterBranch.exporterBranchID " +
                        "INNER JOIN tblExporter a on tblExporterBranch.exporterID = a.exporterID " +
                        "INNER JOIN tblTransProductList on tblTransaction.transID = tblTransProductList.transID " +
                        " INNER JOIN tblProduct on tblTransProductList.productID = tblProduct.productID " +
                       "Where tblTransaction.transDate between '" + dtpFrom.Text + "' and  '" + dtpTo.Text + "' " +
                       "Group by  a.exporterName ";



            qryReports(qry);

        }
        public void WitCo()
        {
            string qry = "SELECT  tblTransaction.transDeclarationNum as 'Export Declaration No.', " +
                         "tblExporter.exporterName as 'Exporter/Supplier',  " +
                         "tblImporter.importerName as 'Consignee/Importer', " +
                         "tblTransaction.portOrigin as 'Port of Origin',  " +
                         "tblDestination.destinationName as 'Country of Destination', " +
                         "tblProduct.hsCode as 'HS Code in 8-digit', " +
                        "  tblProduct.productDescription as 'Product Description', " +
                           "tblTransaction.originCriterion as 'Origin Criterion (Box 8)', " +
                           "tblTransaction.remarks as 'Remarks (Box 13)', " +
                        "	tblDestination.FTA as 'Free  Trade Agreement', tblTransProductList.net as ' Net Wt ' " +
                        "FROM tblTransaction " +
                        "INNER JOIN tblTransProductList on tblTransaction.transID = tblTransProductList.transID " +
                        "INNER JOIN tblProduct on tblTransProductList.productID = tblProduct.productID " +
                        "INNER JOIN tblExporterBranch on tblTransaction.exporterBranchID = tblExporterBranch.exporterBranchID " +
                        "INNer join tblExporter on tblExporterBranch.exporterID = tblExporter.exporterID " +
                        "Inner join tblImporter on tblImporter.importerID = tblTransaction.importerID " +
                        "INNER JOIN tblDestination on tblDestination.destinationID = tblTransaction.destinationID " +
                           "WHERE tblTransaction.withCO = 1 and tblTransaction.transDate between '" + dtpFrom.Text + "' and  '" + dtpTo.Text + "' ";

            qryReports(qry);
        }
        public void withOutCo()
        {
            string qry = "SELECT tblTransaction.transDeclarationNum as 'Export Declaration No.', tblExporter.exporterName as 'Exporter/Supplier', tblImporter.importerName as 'Consignee/Importer',tblTransaction.portOrigin as 'Port of Origin', tblDestination.destinationName as 'Country of Destination',tblProduct.hsCode as 'HS Code in 8-digit', tblProduct.productDescription as 'Product Description', tblTransProductList.net as ' Net Wt ' " +
                        "FROM tblTransaction " +
                         "INNER JOIN tblImporter on tblImporter.importerID = tblTransaction.importerID " +
                        "INNER JOIN tblExporterBranch on tblExporterBranch.exporterBranchID = tblTransaction.exporterBranchID " +
                         "  INNER JOIN tblExporter on tblExporter.exporterID = tblExporterBranch.exporterBranchID " +
                          "INNER JOIN tblDestination on tblDestination.destinationID = tblTransaction.destinationID " +
                           "INNER JOIN tblTransProductList on tblTransProductList.transID = tblTransaction.transID " +
                          "INNER jOIN tblProduct on tblProduct.productID = tblTransProductList.productID " +
                         "WHERE tblTransaction.withCO = 0 and tblTransaction.transDate between '" + dtpFrom.Text + "' and  '" + dtpTo.Text + "' ";
            qryReports(qry);
        }

        public void stats()
        {
            string qry = "SELECT tblTransStandard.transStandardCode, tblExporter.exporterName, tblExporterBranch.exporterAddress, tblImporter.importerName, tblTransaction.portOrigin,tblDestination.destinationName, " +
                        "tblProduct.hsCode, tblProduct.productDescription, tblTransaction.originCriterion, tblTransaction.remarks, tblTransaction.coReferenceNum, tblDestination.FTA, tblTransProductList.volume, tblTransProductList.net, tblTransProductList.gross, " +
                        "tblVessel.vesselName, tblTransaction.voyageNum,tblTransaction.atl, tblExaminer.firstname + tblExaminer.lastname as Examiner, tblTransaction.transStandardID " +
                         "FROM tblTransaction " +
                        "INNER JOIN tblTransStandard on tblTransaction.transStandardID = tblTransStandard.transStandardID " +
                        "INNER JOIN tblExporterBranch on tblTransaction.exporterBranchID = tblExporterBranch.exporterBranchID " +
                        "INNER JOIN tblExporter on tblExporter.exporterID = tblExporterBranch.exporterID " +
                        "INNER JOIN tblImporter on tblTransaction.importerID = tblImporter.importerID " +
                        "INNER JOIN tblDestination on tblDestination.destinationID = tblTransaction.destinationID " +
                        "INNER JOIN tblTransProductList on tblTransProductList.transID = tblTransaction.transID " +
                        "INNER JOIN tblProduct on tblTransProductList.productID = tblProduct.productID " +
                        "INNER JOIN tblVessel on tblTransaction.vesselID = tblVessel.vesselID " +
                        "INNER JOIN tblExaminer on tblTransaction.examinerID = tblExaminer.examinerID " +
                        "INNER join tblStatus on tblTransaction.statusID = tblStatus.statusID " +
                          "WHERE tblTransaction.transDate between '" + dtpFrom.Text + "' and  '" + dtpTo.Text + "' ";


            qryReports(qry);
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFrom.Value > dtpTo.Value)
            {
                MessageBox.Show("From date must not be greater than To Date");
            }
            else
            {
                if (rptEx == 1)
                {
                    ExDes();
                }
                if (rptEx == 2)
                {
                    ExCom();
                }
                if (rptEx == 3)
                {
                    Ex();
                }
                if (rptEx == 4)
                {
                    WitCo();
                }
                if (rptEx == 5)
                {
                    withOutCo();
                }
                if (rptEx == 6)
                {

                }
            }

        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFrom.Value > dtpTo.Value)
            {
                MessageBox.Show("From Date must not be greater than To Date");
            }
            else
            {
                if (rptEx == 1)
                {
                    ExDes();
                }
                if (rptEx == 2)
                {
                    ExCom();
                }
                if (rptEx == 3)
                {
                    Ex();
                }
                if (rptEx == 4)
                {
                    WitCo();
                }
                if (rptEx == 5)
                {
                    withOutCo();
                }
                if (rptEx == 6)
                {

                }
            }
        }

        private void btnDeleteExaminer_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to delete this examiner?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                SQLconnect.Close();
                //
                sqlCommand = new SqlCommand("DELETE from tblexaminer where examinerID =" + txtExaminerID.Text + " ", SQLconnect);

                SQLconnect.Open();
                try
                {
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }

                SQLconnect.Close();
                examiners();
            }
        }

        private void btnCancelExaminer_Click(object sender, EventArgs e)
        {
            examiners();
        }

        private void btnSaveExaminer_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedbtn == 1)
                {

                    if (txtFirstname.Text != "" && txtLastname.Text != "" && txtMI.Text != "")
                    {
                        SQLconnect.Close();
                        //
                        sqlCommand = new SqlCommand("SELECT COUNT(*) from tblExaminer where firstname = '" + txtFirstname.Text + "' and  lastname = '" + txtLastname.Text + "' and  mi = '" + txtMI.Text + "'", SQLconnect);

                        SQLconnect.Open();

                        Int32 count = (Int32)sqlCommand.ExecuteScalar();

                        SQLconnect.Close();
                        //MessageBox.Show(count.ToString());
                        if (count > 0)
                        {
                            MessageBox.Show("examiner already exist!");
                        }
                        else
                        {
                            SQLconnect.Close();
           
                            sqlCommand = new SqlCommand("INSERT INTO tblExaminer (firstname, lastname, mi) values('" + txtFirstname.Text + "','" + txtLastname.Text + "', '" + txtMI.Text + "')", SQLconnect);

                      
                            SQLconnect.Open();

                            sqlCommand.ExecuteNonQuery();

                            SQLconnect.Close();
                            MessageBox.Show("examiner added successfully",
                            "Data Saved",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information,
                            MessageBoxDefaultButton.Button1);
                            examiners();
                        }
                    }
                    else
                    {

                        MessageBox.Show("examiner details is incomplete",
                        "Data incomplete",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1);

                    }
                }
                if (selectedbtn == 2)
                {
                    if (txtFirstname.Text != "" && txtLastname.Text != "" && txtMI.Text != "")
                    {
                        SQLconnect.Close();
                        //
                        sqlCommand = new SqlCommand("SELECT COUNT(*) from tblExaminer where firstname = '" + txtFirstname.Text + "' and  lastname = '" + txtLastname.Text + "' and  mi = '" + txtMI.Text + "' and firstname <> '" + firstname+ "' and  lastname = '" + lastname + "' and  mi = '" + mi+ "'", SQLconnect);

                        SQLconnect.Open();

                        Int32 count = (Int32)sqlCommand.ExecuteScalar();

                        SQLconnect.Close();
                        //MessageBox.Show(count.ToString());
                        if (count > 0)
                        {
                            MessageBox.Show("examiner already exist!");
                        }
                        else
                        {
                            SQLconnect.Close();
                           
                           
                            sqlCommand = new SqlCommand("Update tblExaminer set firstname = '" + txtFirstname.Text + "', lastname = '" + txtLastname.Text + "', mi =  '" + txtMI.Text + "' where examinerID = " + txtExaminerID.Text + " ", SQLconnect);
                            
                            SQLconnect.Open();

                            sqlCommand.ExecuteNonQuery();

                            SQLconnect.Close();
                            MessageBox.Show("examiner updated successfully",
                            "Data Saved",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information,
                            MessageBoxDefaultButton.Button1);
                            examiners();
                        }

                    }
                    else
                    {

                        MessageBox.Show("examiner details is incomplete",
                        "Data incomplete",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1);

                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            username = txtUsername.Text;
            userAddEdit();
            selectedbtn = 2;
        }

        private void btnSaveTransaction_Click(object sender, EventArgs e)
        {
         
        
                
     
            //save transacitons----------------------------
            int wco, etype;
            if(chkWithCO.Checked == true)
            {
                wco = 1;
            }
            else
            {
                wco = 0;
            }
            if(radAir.Checked == true)
            {
                etype = 1;
            }
            else
            {
                etype = 2;
            }
   
            int newID;
            using (var con = new SqlConnection(conStr))
            {
                
                var cmd = "INSERT INTO tblTransaction (transDate, transStandardID, " +
                "transDeclarationNum,exportTypeID, exporterBranchID, importerID, portOrigin, " +
                "destinationID,withCO, originCriterion, remarks, coReferenceNum, vesselID, " +
                "voyageNum,atl, examinerID, statusID, userID)" +
                "VALUES ('" + dtpTrans.Value.Date.ToString("yyyyMMdd") + "'," + cboStandard.SelectedValue + ",'" + txtTransDecNum.Text + "'," + etype + ", " + cboTransExporter.SelectedValue + ", " + cboTransImporter.SelectedValue + ",'" + txtPort.Text + "', " + cboTransDestination.SelectedValue + ", " + wco + ", '" + txtTransOriginCriterion.Text + "','" + txtTransRemarks.Text + "', '" + txtTransCoRefer.Text + "', " + cboTransVessel.SelectedValue + " , '" + txtVoyageNum.Text + "', '" + txtATL.Text + "', " + cboTransExaminer.SelectedValue + ", 1, " + userIDLOGIN + "); SELECT CAST(scope_identity() AS int)";
                using (var insertCommand = new SqlCommand(cmd, con))
                {
                    insertCommand.Parameters.AddWithValue("transID", "bar");
                    con.Open();
                    newID = (int)insertCommand.ExecuteScalar();
                }
            }
            //save product list-------------------------
            foreach (Control controlVariable in pnlProductListContainer.Controls)
            {
                if (controlVariable is UserControls.ctrlProductSearch)
                {

                    ComboBox cboProduct = (ComboBox)controlVariable.Controls["cboProduct"];
                    TextBox txtNet = (TextBox)controlVariable.Controls["txtNet"];

                    TextBox txtGross = (TextBox)controlVariable.Controls["txtGross"];

                    TextBox txtVolume = (TextBox)controlVariable.Controls["txtVolume"];
                    //cboProduct.SelectedValue
                    //MessageBox.Show(txtHSCODE.Text);

                    SQLconnect.Close();
                    //
                    sqlCommand = new SqlCommand("INSERT INTO tblTransProductList(transID, productID, volume, net, gross) values (" + newID + ", "+ cboProduct.SelectedValue+", "+ txtGross.Text + ", " + txtNet.Text + ", " + txtGross.Text + ")", SQLconnect);
                    //INSERT INTO tblTransProductList(transID, productID, volume, net, gross) 
                    //values("+newID+", "+cboProduct.SelectedValue.ToString+ ", " + txtGross.Text + ", " + txtNet.Text + ", " + txtGross.Text + ")

                    SQLconnect.Open();

                    sqlCommand.ExecuteNonQuery();

                    SQLconnect.Close();
                    
                    ///////////////////////////////////////////////////////////////////
                }

            }
            MessageBox.Show("Transaction saved successfully",
            "Data Saved",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1);

            transactions();

        }

        private void btnSaveExporter_Click(object sender, EventArgs e)
        {
            pnlBranchMain.Enabled = true;
            try
            {
                if (selectedbtn == 1)
                {

                    if (txtExporterName.Text != "")
                    {
                        SQLconnect.Close();
                        //
                        sqlCommand = new SqlCommand("SELECT COUNT(*) from tblExporter where exporterName = '" + txtExporterName.Text + "'", SQLconnect);

                        SQLconnect.Open();

                        Int32 count = (Int32)sqlCommand.ExecuteScalar();

                        SQLconnect.Close();
                        //MessageBox.Show(count.ToString());
                        if (count > 0)
                        {
                            MessageBox.Show("Exporter already exist!");
                        }
                        else
                        {
                            SQLconnect.Close();
                            //
                            sqlCommand = new SqlCommand("INSERT INTO tblExporter (exporterName) values('" + txtExporterName.Text + "')", SQLconnect);

                            SQLconnect.Open();

                            sqlCommand.ExecuteNonQuery();

                            SQLconnect.Close();
                            MessageBox.Show("Exporter added successfully",
                            "Data Saved",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information,
                            MessageBoxDefaultButton.Button1);
                            exporters();
                        }
                    }
                    else
                    {

                        MessageBox.Show("Exporter details is incomplete",
                        "Data incomplete",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1);

                    }
                }
                if (selectedbtn == 2)
                {
                    if (txtExporterName.Text != "")
                    {
                        SQLconnect.Close();
                        //
                        sqlCommand = new SqlCommand("SELECT COUNT(*) from tblExporter where exporterName = '" + txtExporterName.Text + "' and exporterName <> '" + exporterName + "'", SQLconnect);
                        // sqlCommand = new SqlCommand("SELECT COUNT(*) from tblProduct where hsCode = '" + txtHSCOde.Text + "' and hsCode <> '" + hsCode + "'", SQLconnect);
                        SQLconnect.Open();

                        Int32 count = (Int32)sqlCommand.ExecuteScalar();

                        SQLconnect.Close();
                        //MessageBox.Show(count.ToString());
                        if (count > 0)
                        {
                            MessageBox.Show("Exporter already exist!");
                        }
                        else
                        {
                            SQLconnect.Close();
                            //
                            sqlCommand = new SqlCommand("Update tblExporter set exporterName = '" + txtExporterName.Text + "' where exporterID = " + txtExporterID.Text + " ", SQLconnect);

                            SQLconnect.Open();

                            sqlCommand.ExecuteNonQuery();

                            SQLconnect.Close();
                            MessageBox.Show("Exporter updated successfully",
                            "Data Saved",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information,
                            MessageBoxDefaultButton.Button1);
                            exporters();
                        }

                    }
                    else
                    {

                        MessageBox.Show("Exporter details is incomplete",
                        "Data incomplete",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1);

                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
      
        }

  

       
      

        private void btnEditExporter_Click(object sender, EventArgs e)
        {
            exporterName = txtExporterName.Text;
            selectedbtn = 2;
            exporterAddEdit();
        }

        private void btnEditVessel_Click(object sender, EventArgs e)
        {
            vesselName = txtVesselName.Text;

            selectedbtn = 2;
            vesselAddEdit();


        }

        private void btnCancelImporter_Click(object sender, EventArgs e)
        {
            importers();
        }
    }

}
