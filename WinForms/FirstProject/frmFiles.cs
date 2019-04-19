using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstProject
{
    public partial class frmFiles : Form
    {
        public frmFiles()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.ShowDialog();
            FileStream fs = new FileStream(dialog.FileName, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            txtNotepad.Text = sr.ReadToEnd();
            sr.Close();
            fs.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtNotepad.Clear();
            txtNotepad.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.ShowDialog();
            dialog.FileName = dialog.FileName + ".txt";
            FileStream fs = new FileStream(dialog.FileName, FileMode.Create, 
                    FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(txtNotepad.Text);
            sw.Close();
            fs.Close();
        }
    }
}
