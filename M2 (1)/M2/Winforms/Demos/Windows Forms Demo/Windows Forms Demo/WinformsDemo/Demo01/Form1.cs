using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo01
{
    public partial class FormMainWindow : Form
    {
        public FormMainWindow()
        {
            InitializeComponent();
        }

        private void btnShowMsgBox_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Message","Title",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            if (result == DialogResult.OK)
                MessageBox.Show("Ok Pressed","OK");
            else
                MessageBox.Show("Cancel Pressed","Cancel");
        }

        private void btnCustomDialog_Click(object sender, EventArgs e)
        {
            Form customDialog = CustomDialogForm.GetInstance();
            customDialog.ShowDialog();
        }
    }
}
