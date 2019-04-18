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
    public partial class Demo07 : Form
    {
        public Demo07()
        {
            InitializeComponent();
        }

        private void btnXMLTextReader_Click(object sender, EventArgs e)
        {
            int ws = 0;
            int pi = 0;
            int dc = 0;
            int cc = 0;
            int ac = 0;
            int et = 0;
            int el = 0;
            int xd = 0;
            // Read a document
            XmlTextReader textReader = new XmlTextReader("..\\..\\products.xml");
            // Read until end of file
            while (textReader.Read())
            {
                //XmlNodeType nType = textReader.NodeType;
                XmlNodeType nType = textReader.NodeType;
                // If node type us a declaration
                if (nType == XmlNodeType.XmlDeclaration)
                {
                    MessageBox.Show("Declaration:" + textReader.Name.ToString());
                    xd = xd + 1;
                }
                // if node type is a comment
                if (nType == XmlNodeType.Comment)
                {
                    MessageBox.Show("Comment:" + textReader.Name.ToString());
                    cc = cc + 1;
                }
                // if node type us an attribute
                if (nType == XmlNodeType.Attribute)
                {
                    MessageBox.Show("Attribute:" + textReader.Name.ToString());
                    ac = ac + 1;
                }
                // if node type is an element
                if (nType == XmlNodeType.Element)
                {
                    MessageBox.Show("Element:" + textReader.Name.ToString());
                    el = el + 1;
                }
                // if node type is an entity\
                if (nType == XmlNodeType.Entity)
                {
                    MessageBox.Show("Entity:" + textReader.Name.ToString());
                    et = et + 1;
                }
                // if node type is a Process Instruction
                if (nType == XmlNodeType.ProcessingInstruction)
                {
                    MessageBox.Show("Entity:" + textReader.Name.ToString());
                    pi = pi + 1;
                }
                // if node type a document
                if (nType == XmlNodeType.DocumentType)
                {
                    MessageBox.Show("Document:" + textReader.Name.ToString());
                    dc = dc + 1;
                }
                // if node type is white space
                if (nType == XmlNodeType.Whitespace)
                {
                    MessageBox.Show("WhiteSpace:" + textReader.Name.ToString());
                    ws = ws + 1;
                }
            }
            // Write the summary
            MessageBox.Show("Total Comments:" + cc.ToString());
            MessageBox.Show("Total Attributes:" + ac.ToString());
            MessageBox.Show("Total Elements:" + el.ToString());
            MessageBox.Show("Total Entity:" + et.ToString());
            MessageBox.Show("Total Process Instructions:" + pi.ToString());
            MessageBox.Show("Total Declaration:" + xd.ToString());
            MessageBox.Show("Total DocumentType:" + dc.ToString());
            MessageBox.Show("Total WhiteSpaces:" + ws.ToString());
            Console.ReadLine();

        }
    }
}
