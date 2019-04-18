using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Day02
{
    public partial class Demo09 : Form
    {
        SqlDataAdapter daProduct;
        DataSet dsProduct;

     
        public Demo09()
        {
            InitializeComponent();
        }

        private void Demo09_Load(object sender, EventArgs e)
        {
            string sqlConnectString = ConfigurationManager.ConnectionStrings["AdventureWorks"].ConnectionString;
            SqlConnection connection = new SqlConnection(sqlConnectString);

            daProduct = new SqlDataAdapter("Select * from Production.Product", connection);
            connection.Open();
            dsProduct = new DataSet();
            daProduct.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            daProduct.Fill(dsProduct, "Product");

            SqlCommandBuilder cb = new SqlCommandBuilder(daProduct);

        }

        private void btnSaveToXML_Click(object sender, EventArgs e)
        {
            //Save Schema and Data into xml file
            dsProduct.WriteXmlSchema("..\\..\\products.xsd");
            dsProduct.WriteXml("..\\..\\products.xml", XmlWriteMode.IgnoreSchema);
            MessageBox.Show("Data saved to disk");            
        }

        private void btnLoadFromXML_Click(object sender, EventArgs e)
        {
            //Read Data from xml file into Data Set
            dsProduct.ReadXmlSchema("..\\..\\products.xsd");
            dsProduct = new DataSet();
            dsProduct.ReadXml("..\\..\\products.xml", XmlReadMode.IgnoreSchema);
            dataGridView1.DataSource = dsProduct.Tables["Product"];
            MessageBox.Show("Data read from XML");

        }

        private void btnSaveToDB_Click(object sender, EventArgs e)
        {
            try
            {
                daProduct.Update(dsProduct.Tables["Product"]);
                MessageBox.Show("Changes Saved");
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show(sqlex.Message);
            }
	
        }

        private void btnLoadFromDB_Click(object sender, EventArgs e)
        {
            daProduct.Fill(dsProduct, "Product");
            dataGridView1.DataSource = dsProduct.Tables["Product"];
            btnLoadFromDB.Enabled = false;

        }
    }
}