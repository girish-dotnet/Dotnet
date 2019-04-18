namespace Day02
{
    partial class Demo09
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSaveToXML = new System.Windows.Forms.Button();
            this.btnLoadFromXML = new System.Windows.Forms.Button();
            this.btnSaveToDB = new System.Windows.Forms.Button();
            this.btnLoadFromDB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(577, 282);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnSaveToXML
            // 
            this.btnSaveToXML.Location = new System.Drawing.Point(12, 318);
            this.btnSaveToXML.Name = "btnSaveToXML";
            this.btnSaveToXML.Size = new System.Drawing.Size(114, 23);
            this.btnSaveToXML.TabIndex = 1;
            this.btnSaveToXML.Text = "Save To XML";
            this.btnSaveToXML.UseVisualStyleBackColor = true;
            this.btnSaveToXML.Click += new System.EventHandler(this.btnSaveToXML_Click);
            // 
            // btnLoadFromXML
            // 
            this.btnLoadFromXML.Location = new System.Drawing.Point(183, 318);
            this.btnLoadFromXML.Name = "btnLoadFromXML";
            this.btnLoadFromXML.Size = new System.Drawing.Size(107, 23);
            this.btnLoadFromXML.TabIndex = 2;
            this.btnLoadFromXML.Text = "Load From XML";
            this.btnLoadFromXML.UseVisualStyleBackColor = true;
            this.btnLoadFromXML.Click += new System.EventHandler(this.btnLoadFromXML_Click);
            // 
            // btnSaveToDB
            // 
            this.btnSaveToDB.Location = new System.Drawing.Point(461, 318);
            this.btnSaveToDB.Name = "btnSaveToDB";
            this.btnSaveToDB.Size = new System.Drawing.Size(116, 23);
            this.btnSaveToDB.TabIndex = 3;
            this.btnSaveToDB.Text = "Save To Database";
            this.btnSaveToDB.UseVisualStyleBackColor = true;
            this.btnSaveToDB.Click += new System.EventHandler(this.btnSaveToDB_Click);
            // 
            // btnLoadFromDB
            // 
            this.btnLoadFromDB.Location = new System.Drawing.Point(316, 318);
            this.btnLoadFromDB.Name = "btnLoadFromDB";
            this.btnLoadFromDB.Size = new System.Drawing.Size(116, 23);
            this.btnLoadFromDB.TabIndex = 4;
            this.btnLoadFromDB.Text = "Load From Database";
            this.btnLoadFromDB.UseVisualStyleBackColor = true;
            this.btnLoadFromDB.Click += new System.EventHandler(this.btnLoadFromDB_Click);
            // 
            // Demo09
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 367);
            this.Controls.Add(this.btnLoadFromDB);
            this.Controls.Add(this.btnSaveToDB);
            this.Controls.Add(this.btnLoadFromXML);
            this.Controls.Add(this.btnSaveToXML);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Demo09";
            this.Text = "Demo09";
            this.Load += new System.EventHandler(this.Demo09_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSaveToXML;
        private System.Windows.Forms.Button btnLoadFromXML;
        private System.Windows.Forms.Button btnSaveToDB;
        private System.Windows.Forms.Button btnLoadFromDB;
    }
}