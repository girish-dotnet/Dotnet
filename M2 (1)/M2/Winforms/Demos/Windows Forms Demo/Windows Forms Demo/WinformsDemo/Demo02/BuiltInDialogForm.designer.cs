namespace Demo02
{
    partial class BuiltInDialogForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnColorDialog = new System.Windows.Forms.Button();
            this.btnFontDialog = new System.Windows.Forms.Button();
            this.btnOpenFileDialog = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtLoadFileDetails = new System.Windows.Forms.TextBox();
            this.btnFolderBrowserDlg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnColorDialog
            // 
            this.btnColorDialog.Location = new System.Drawing.Point(26, 29);
            this.btnColorDialog.Name = "btnColorDialog";
            this.btnColorDialog.Size = new System.Drawing.Size(236, 27);
            this.btnColorDialog.TabIndex = 0;
            this.btnColorDialog.Text = "Color Dialog";
            this.btnColorDialog.UseVisualStyleBackColor = true;
            this.btnColorDialog.Click += new System.EventHandler(this.btnColorDialog_Click);
            // 
            // btnFontDialog
            // 
            this.btnFontDialog.Location = new System.Drawing.Point(32, 78);
            this.btnFontDialog.Name = "btnFontDialog";
            this.btnFontDialog.Size = new System.Drawing.Size(229, 30);
            this.btnFontDialog.TabIndex = 1;
            this.btnFontDialog.Text = "FontDialog";
            this.btnFontDialog.UseVisualStyleBackColor = true;
            this.btnFontDialog.Click += new System.EventHandler(this.btnFontDialog_Click);
            // 
            // btnOpenFileDialog
            // 
            this.btnOpenFileDialog.Location = new System.Drawing.Point(32, 134);
            this.btnOpenFileDialog.Name = "btnOpenFileDialog";
            this.btnOpenFileDialog.Size = new System.Drawing.Size(227, 36);
            this.btnOpenFileDialog.TabIndex = 2;
            this.btnOpenFileDialog.Text = "Open Dialog";
            this.btnOpenFileDialog.UseVisualStyleBackColor = true;
            this.btnOpenFileDialog.Click += new System.EventHandler(this.btnOpenFileDialog_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Text Files(*.txt)|*.txt|All Files(*.*)|*.*";
            this.openFileDialog1.Title = "Open File Dialog";
            // 
            // txtLoadFileDetails
            // 
            this.txtLoadFileDetails.Location = new System.Drawing.Point(26, 199);
            this.txtLoadFileDetails.Multiline = true;
            this.txtLoadFileDetails.Name = "txtLoadFileDetails";
            this.txtLoadFileDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLoadFileDetails.Size = new System.Drawing.Size(235, 101);
            this.txtLoadFileDetails.TabIndex = 3;
            // 
            // btnFolderBrowserDlg
            // 
            this.btnFolderBrowserDlg.Location = new System.Drawing.Point(29, 322);
            this.btnFolderBrowserDlg.Name = "btnFolderBrowserDlg";
            this.btnFolderBrowserDlg.Size = new System.Drawing.Size(232, 45);
            this.btnFolderBrowserDlg.TabIndex = 4;
            this.btnFolderBrowserDlg.Text = "FolderBrowser Dialog";
            this.btnFolderBrowserDlg.UseVisualStyleBackColor = true;
            this.btnFolderBrowserDlg.Click += new System.EventHandler(this.btnFolderBrowserDlg_Click);
            // 
            // BuiltInDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 393);
            this.Controls.Add(this.btnFolderBrowserDlg);
            this.Controls.Add(this.txtLoadFileDetails);
            this.Controls.Add(this.btnOpenFileDialog);
            this.Controls.Add(this.btnFontDialog);
            this.Controls.Add(this.btnColorDialog);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BuiltInDialogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Built-In Dialogs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnColorDialog;
        private System.Windows.Forms.Button btnFontDialog;
        private System.Windows.Forms.Button btnOpenFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtLoadFileDetails;
        private System.Windows.Forms.Button btnFolderBrowserDlg;
    }
}