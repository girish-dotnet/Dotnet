namespace Day02
{
    partial class Demo07
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
            this.btnXMLTextReader = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnXMLTextReader
            // 
            this.btnXMLTextReader.Location = new System.Drawing.Point(54, 107);
            this.btnXMLTextReader.Name = "btnXMLTextReader";
            this.btnXMLTextReader.Size = new System.Drawing.Size(176, 49);
            this.btnXMLTextReader.TabIndex = 1;
            this.btnXMLTextReader.Text = "Working With XMLTextReader";
            this.btnXMLTextReader.UseVisualStyleBackColor = true;
            this.btnXMLTextReader.Click += new System.EventHandler(this.btnXMLTextReader_Click);
            // 
            // Demo07
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnXMLTextReader);
            this.Name = "Demo07";
            this.Text = "Demo07";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnXMLTextReader;
    }
}