namespace Day02
{
    partial class Demo01
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
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.btnFillGrid = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCategories = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(70, 173);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(423, 250);
            this.dgvProducts.TabIndex = 3;
            // 
            // btnFillGrid
            // 
            this.btnFillGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnFillGrid.Location = new System.Drawing.Point(174, 95);
            this.btnFillGrid.Name = "btnFillGrid";
            this.btnFillGrid.Size = new System.Drawing.Size(211, 39);
            this.btnFillGrid.TabIndex = 2;
            this.btnFillGrid.Text = "Fill Grid";
            this.btnFillGrid.UseVisualStyleBackColor = true;
            this.btnFillGrid.Click += new System.EventHandler(this.btnFillGrid_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Using DataSet && DataAdapter";
            // 
            // dgvCategories
            // 
            this.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategories.Location = new System.Drawing.Point(558, 173);
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.Size = new System.Drawing.Size(336, 250);
            this.dgvCategories.TabIndex = 5;
            // 
            // Demo01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 456);
            this.Controls.Add(this.dgvCategories);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.btnFillGrid);
            this.Name = "Demo01";
            this.Text = "Demo01";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnFillGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCategories;
    }
}