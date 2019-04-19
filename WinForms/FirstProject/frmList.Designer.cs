namespace FirstProject
{
    partial class frmList
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
            this.lstSource = new System.Windows.Forms.ListBox();
            this.lstTarget = new System.Windows.Forms.ListBox();
            this.btnGt = new System.Windows.Forms.Button();
            this.btnDgt = new System.Windows.Forms.Button();
            this.btnLt = new System.Windows.Forms.Button();
            this.btnDlt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstSource
            // 
            this.lstSource.FormattingEnabled = true;
            this.lstSource.Location = new System.Drawing.Point(197, 119);
            this.lstSource.Name = "lstSource";
            this.lstSource.Size = new System.Drawing.Size(130, 212);
            this.lstSource.TabIndex = 0;
            // 
            // lstTarget
            // 
            this.lstTarget.FormattingEnabled = true;
            this.lstTarget.Location = new System.Drawing.Point(557, 119);
            this.lstTarget.Name = "lstTarget";
            this.lstTarget.Size = new System.Drawing.Size(130, 212);
            this.lstTarget.TabIndex = 1;
            // 
            // btnGt
            // 
            this.btnGt.Location = new System.Drawing.Point(398, 130);
            this.btnGt.Name = "btnGt";
            this.btnGt.Size = new System.Drawing.Size(55, 31);
            this.btnGt.TabIndex = 2;
            this.btnGt.Text = ">";
            this.btnGt.UseVisualStyleBackColor = true;
            this.btnGt.Click += new System.EventHandler(this.btnGt_Click);
            // 
            // btnDgt
            // 
            this.btnDgt.Location = new System.Drawing.Point(398, 188);
            this.btnDgt.Name = "btnDgt";
            this.btnDgt.Size = new System.Drawing.Size(55, 31);
            this.btnDgt.TabIndex = 3;
            this.btnDgt.Text = ">>";
            this.btnDgt.UseVisualStyleBackColor = true;
            this.btnDgt.Click += new System.EventHandler(this.btnDgt_Click);
            // 
            // btnLt
            // 
            this.btnLt.Location = new System.Drawing.Point(398, 242);
            this.btnLt.Name = "btnLt";
            this.btnLt.Size = new System.Drawing.Size(55, 31);
            this.btnLt.TabIndex = 4;
            this.btnLt.Text = "<";
            this.btnLt.UseVisualStyleBackColor = true;
            // 
            // btnDlt
            // 
            this.btnDlt.Location = new System.Drawing.Point(398, 300);
            this.btnDlt.Name = "btnDlt";
            this.btnDlt.Size = new System.Drawing.Size(55, 31);
            this.btnDlt.TabIndex = 5;
            this.btnDlt.Text = "<<";
            this.btnDlt.UseVisualStyleBackColor = true;
            // 
            // frmList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 542);
            this.Controls.Add(this.btnDlt);
            this.Controls.Add(this.btnLt);
            this.Controls.Add(this.btnDgt);
            this.Controls.Add(this.btnGt);
            this.Controls.Add(this.lstTarget);
            this.Controls.Add(this.lstSource);
            this.Name = "frmList";
            this.Text = "frmList";
            this.Load += new System.EventHandler(this.frmList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstSource;
        private System.Windows.Forms.ListBox lstTarget;
        private System.Windows.Forms.Button btnGt;
        private System.Windows.Forms.Button btnDgt;
        private System.Windows.Forms.Button btnLt;
        private System.Windows.Forms.Button btnDlt;
    }
}