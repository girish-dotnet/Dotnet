using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Demo02
{
    public partial class BuiltInDialogForm : Form
    {
        public BuiltInDialogForm()
        {
            InitializeComponent();
        }

        private void btnColorDialog_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.FullOpen = true;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog.Color;
            }
        }

        private void btnFontDialog_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog= new FontDialog();
            fontDialog.ShowColor = true;
            fontDialog.ShowApply = true;
            fontDialog.ShowEffects = true;
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                btnFontDialog.Font = fontDialog.Font;
                btnFontDialog.ForeColor = fontDialog.Color;
            }
        }

        private void btnOpenFileDialog_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                txtLoadFileDetails.Text =  sr.ReadToEnd();
                sr.Close();
                fs.Close();
            }
        }

        private void btnFolderBrowserDlg_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbDlg = new FolderBrowserDialog();
            if (fbDlg.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(fbDlg.SelectedPath,"Folder Path");
            }
        }
    }
}
