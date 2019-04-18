namespace Day02
{
    partial class Demo04
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
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.dataGrid2 = new System.Windows.Forms.DataGrid();
            this.Label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid1
            // 
            this.dataGrid1.DataMember = "";
            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid1.Location = new System.Drawing.Point(1, 61);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(695, 253);
            this.dataGrid1.TabIndex = 1;
            // 
            // dataGrid2
            // 
            this.dataGrid2.DataMember = "";
            this.dataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid2.Location = new System.Drawing.Point(1, 320);
            this.dataGrid2.Name = "dataGrid2";
            this.dataGrid2.Size = new System.Drawing.Size(695, 253);
            this.dataGrid2.TabIndex = 0;
            // 
            // Label7
            // 
            this.Label7.AccessibleDescription = "Label with text \"Using Stored Procedures\"";
            this.Label7.AccessibleName = "Application Title";
            this.Label7.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label7.Location = new System.Drawing.Point(180, 9);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(244, 33);
            this.Label7.TabIndex = 5;
            this.Label7.Text = "Using DataView Object";
            // 
            // Demo04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 501);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.dataGrid2);
            this.Controls.Add(this.dataGrid1);
            this.Name = "Demo04";
            this.Text = "Demo04";
            this.Load += new System.EventHandler(this.Demo04_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGrid dataGrid1;
        private System.Windows.Forms.DataGrid dataGrid2;
        private System.Windows.Forms.Label Label7;


    }
}