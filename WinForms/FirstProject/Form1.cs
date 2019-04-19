using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to C# WinForms");
        }

        private void btnLunch_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lunch Time at 12.30 PM");
        }
    }
}
