namespace Day02
{
    partial class Demo08
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
            this.OrderDisplay = new System.Windows.Forms.TextBox();
            this.OrderLogSummary = new System.Windows.Forms.Button();
            this.ProductID = new System.Windows.Forms.TextBox();
            this.QueryProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.IdentifyProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OrderDisplay
            // 
            this.OrderDisplay.Location = new System.Drawing.Point(12, 12);
            this.OrderDisplay.Multiline = true;
            this.OrderDisplay.Name = "OrderDisplay";
            this.OrderDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OrderDisplay.Size = new System.Drawing.Size(371, 221);
            this.OrderDisplay.TabIndex = 0;
            // 
            // OrderLogSummary
            // 
            this.OrderLogSummary.Location = new System.Drawing.Point(398, 12);
            this.OrderLogSummary.Name = "OrderLogSummary";
            this.OrderLogSummary.Size = new System.Drawing.Size(118, 23);
            this.OrderLogSummary.TabIndex = 1;
            this.OrderLogSummary.Text = "Order Log Summary";
            this.OrderLogSummary.Click += new System.EventHandler(this.OrderLogSummary_Click);
            // 
            // ProductID
            // 
            this.ProductID.Location = new System.Drawing.Point(12, 280);
            this.ProductID.Name = "ProductID";
            this.ProductID.Size = new System.Drawing.Size(100, 20);
            this.ProductID.TabIndex = 2;
            // 
            // QueryProduct
            // 
            this.QueryProduct.Location = new System.Drawing.Point(131, 280);
            this.QueryProduct.Name = "QueryProduct";
            this.QueryProduct.Size = new System.Drawing.Size(176, 23);
            this.QueryProduct.TabIndex = 3;
            this.QueryProduct.Text = "Query Product";
            this.QueryProduct.Click += new System.EventHandler(this.QueryProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Which Product do you want more information on?";
            // 
            // IdentifyProduct
            // 
            this.IdentifyProduct.Location = new System.Drawing.Point(131, 309);
            this.IdentifyProduct.Name = "IdentifyProduct";
            this.IdentifyProduct.Size = new System.Drawing.Size(176, 23);
            this.IdentifyProduct.TabIndex = 6;
            this.IdentifyProduct.Text = "Identify Product";
            this.IdentifyProduct.Click += new System.EventHandler(this.IdentifyProduct_Click);
            // 
            // Demo08
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 344);
            this.Controls.Add(this.IdentifyProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QueryProduct);
            this.Controls.Add(this.ProductID);
            this.Controls.Add(this.OrderLogSummary);
            this.Controls.Add(this.OrderDisplay);
            this.Name = "Demo08";
            this.Text = "Log Reporting";
            this.Load += new System.EventHandler(this.Demo08_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.TextBox OrderDisplay;
        private System.Windows.Forms.Button OrderLogSummary;
        private System.Windows.Forms.TextBox ProductID;
        private System.Windows.Forms.Button QueryProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button IdentifyProduct;


        #endregion

    }
}