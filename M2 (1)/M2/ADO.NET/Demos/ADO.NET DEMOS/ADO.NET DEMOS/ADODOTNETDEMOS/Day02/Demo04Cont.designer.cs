namespace Day02
{
    partial class Demo04Cont
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
            this.gridArgentina = new System.Windows.Forms.DataGrid();
            this.gridBrazil = new System.Windows.Forms.DataGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gridAll = new System.Windows.Forms.DataGrid();
            this.Label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridArgentina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBrazil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAll)).BeginInit();
            this.SuspendLayout();
            // 
            // gridArgentina
            // 
            this.gridArgentina.DataMember = "";
            this.gridArgentina.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.gridArgentina.Location = new System.Drawing.Point(12, 86);
            this.gridArgentina.Name = "gridArgentina";
            this.gridArgentina.Size = new System.Drawing.Size(416, 88);
            this.gridArgentina.TabIndex = 0;
            // 
            // gridBrazil
            // 
            this.gridBrazil.DataMember = "";
            this.gridBrazil.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.gridBrazil.Location = new System.Drawing.Point(12, 210);
            this.gridBrazil.Name = "gridBrazil";
            this.gridBrazil.Size = new System.Drawing.Size(416, 96);
            this.gridBrazil.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Customers From Argentina:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customers From Brazil:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "All Customers:";
            // 
            // gridAll
            // 
            this.gridAll.DataMember = "";
            this.gridAll.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.gridAll.Location = new System.Drawing.Point(12, 342);
            this.gridAll.Name = "gridAll";
            this.gridAll.Size = new System.Drawing.Size(416, 96);
            this.gridAll.TabIndex = 0;
            // 
            // Label7
            // 
            this.Label7.AccessibleDescription = "Label with text \"Using Stored Procedures\"";
            this.Label7.AccessibleName = "Application Title";
            this.Label7.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label7.Location = new System.Drawing.Point(94, 9);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(244, 33);
            this.Label7.TabIndex = 6;
            this.Label7.Text = "Using DataView Object";
            // 
            // Demo04Cont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 487);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.gridAll);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridBrazil);
            this.Controls.Add(this.gridArgentina);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Demo04Cont";
            this.Text = "Multiple Views";
            this.Load += new System.EventHandler(this.Demo04Cont_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridArgentina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBrazil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAll)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGrid gridArgentina;
        private System.Windows.Forms.DataGrid gridBrazil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGrid gridAll;
        private System.Windows.Forms.Label Label7;

    }
}