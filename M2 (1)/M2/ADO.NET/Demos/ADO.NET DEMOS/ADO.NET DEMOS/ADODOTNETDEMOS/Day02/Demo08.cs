using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Day02
{
    public partial class Demo08 : Form
    {
        public Demo08()
        {
            InitializeComponent();
        }

        private XmlDocument LoadOrderLog()
        {
            OrderDisplay.Clear();

            // Create the XmlDocument object.
            XmlDocument OrderLog = new XmlDocument();

            // Load the document, and validate it against the schema.
            try
            {
                OrderLog.Load("..\\..\\OrderLog.xml");
            }
            catch (Exception ex)
            {
                OrderDisplay.Text += ex.ToString();
            }
            return OrderLog;
        }


        private void OrderLogSummary_Click(object sender, EventArgs e)
        {
            // Load the XML document.
            XmlDocument OrderLog = LoadOrderLog();

            // Display the number of ProductID elements in the document.
            XmlNodeList elemList = OrderLog.GetElementsByTagName("ProductID");
            OrderDisplay.Text += "The number of products ordered is: " + elemList.Count;

        }

        private void AllOrders_Click(object sender, EventArgs e)
        {
         
        }

        private void QueryProduct_Click(object sender, EventArgs e)
        {
            // Load the XML document.
            XmlDocument OrderLog = LoadOrderLog();

            // Get all the ProductID elements.
            XmlNodeList elemList = OrderLog.GetElementsByTagName("ProductID");

            // Declare variables to track the total and quantity.
            int total = 0;
            int quantity = 0;

            // Iterate through the list of ProductID elements.
            foreach (XmlNode myNode in elemList)
            {
                // Get all of the attributes from the product.
                XmlAttributeCollection attrcol = myNode.Attributes;

                // Get the quantity attribute.
                int att = XmlConvert.ToInt32(attrcol.GetNamedItem("quantity").Value.ToString());

                // If this ProductID element matches the ProductID entered by the customer, increment the total and update the quantity.
                if (myNode.InnerXml == ProductID.Text)
                {
                    total++;
                    quantity += att;
                }
            }
            OrderDisplay.Text += "ProductID " + ProductID.Text + " has " + total + " order(s)";
            OrderDisplay.Text += "\r\nTo fulfill orders for ProductID " + ProductID.Text + " we require a total of  " + quantity + " items.";  

        }

        private void IdentifyProduct_Click(object sender, EventArgs e)
        {
            // Load the XML document.
            XmlDocument OrderLog = LoadOrderLog();

            // Get all child nodes of the root element (these will be Order elements).
            XmlNodeList childNodeList = OrderLog.DocumentElement.ChildNodes;

            // Iterate through the list of Order elements.
            foreach (XmlNode cNode in childNodeList)
            {
                // Get the first child element (this will be ProductID).
                // If this ProductID matches the ProductID entered by the customer, display the product details.
                if (cNode.FirstChild.InnerXml == ProductID.Text)
                {
                    // Get the node after the ProductID element (this will be Product).
                    XmlNode nextNode = cNode.FirstChild.NextSibling;

                    // Get all the child nodes of Product, and display the name/value of each node.
                    XmlNodeList cn = nextNode.ChildNodes;
                    foreach (XmlNode childNode in cn)
                    {
                        OrderDisplay.Text += "\r\nThis Product is: " + childNode.InnerXml.ToString();
                    }
                    break;
                }
            }

        }

        private void Demo08_Load(object sender, EventArgs e)
        {

        }
    }
}
