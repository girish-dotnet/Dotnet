namespace Demo01
{
    partial class FormMainWindow
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
            this.btnShowMsgBox = new System.Windows.Forms.Button();
            this.btnCustomDialog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowMsgBox
            // 
            this.btnShowMsgBox.Location = new System.Drawing.Point(62, 12);
            this.btnShowMsgBox.Name = "btnShowMsgBox";
            this.btnShowMsgBox.Size = new System.Drawing.Size(153, 61);
            this.btnShowMsgBox.TabIndex = 0;
            this.btnShowMsgBox.Text = "Show MessageBox";
            this.btnShowMsgBox.UseVisualStyleBackColor = true;
            this.btnShowMsgBox.Click += new System.EventHandler(this.btnShowMsgBox_Click);
            // 
            // btnCustomDialog
            // 
            this.btnCustomDialog.Location = new System.Drawing.Point(62, 92);
            this.btnCustomDialog.Name = "btnCustomDialog";
            this.btnCustomDialog.Size = new System.Drawing.Size(153, 59);
            this.btnCustomDialog.TabIndex = 1;
            this.btnCustomDialog.Text = "ShowCustomDialog";
            this.btnCustomDialog.UseVisualStyleBackColor = true;
            this.btnCustomDialog.Click += new System.EventHandler(this.btnCustomDialog_Click);
            // 
            // FormMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 187);
            this.Controls.Add(this.btnCustomDialog);
            this.Controls.Add(this.btnShowMsgBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Window";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowMsgBox;
        private System.Windows.Forms.Button btnCustomDialog;

    }
}

