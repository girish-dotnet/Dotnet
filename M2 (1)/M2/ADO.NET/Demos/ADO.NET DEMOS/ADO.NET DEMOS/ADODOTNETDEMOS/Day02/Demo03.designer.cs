namespace Day02
{
    partial class Demo03
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
            this.lstCategories = new System.Windows.Forms.ListBox();
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstCategories
            // 
            this.lstCategories.Location = new System.Drawing.Point(53, 78);
            this.lstCategories.Name = "lstCategories";
            this.lstCategories.Size = new System.Drawing.Size(140, 225);
            this.lstCategories.TabIndex = 0;
            this.lstCategories.SelectedIndexChanged += new System.EventHandler(this.lstCategories_SelectedIndexChanged);
            // 
            // lstProducts
            // 
            this.lstProducts.Location = new System.Drawing.Point(197, 78);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(252, 225);
            this.lstProducts.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(53, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Category:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(197, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Products:";
            // 
            // Label7
            // 
            this.Label7.AccessibleDescription = "Label with text \"Using Stored Procedures\"";
            this.Label7.AccessibleName = "Application Title";
            this.Label7.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label7.Location = new System.Drawing.Point(117, 9);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(244, 33);
            this.Label7.TabIndex = 4;
            this.Label7.Text = "Using DataRelation";
            // 
            // Demo03
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
            this.ClientSize = new System.Drawing.Size(503, 337);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstProducts);
            this.Controls.Add(this.lstCategories);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Demo03";
            this.Text = "A Master-Detail Form";
            this.Load += new System.EventHandler(this.Demo03_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstCategories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.Label Label7;


    }
}