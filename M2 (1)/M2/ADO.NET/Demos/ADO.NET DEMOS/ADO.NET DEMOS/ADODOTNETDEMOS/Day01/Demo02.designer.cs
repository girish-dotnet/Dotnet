namespace Day01
{
    partial class Demo02
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
            this.Label7 = new System.Windows.Forms.Label();
            this.btnGet10MostExpProds = new System.Windows.Forms.Button();
            this.lstTenMostExpProds = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.txtLN = new System.Windows.Forms.TextBox();
            this.txtFN = new System.Windows.Forms.TextBox();
            this.txtCID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnOutputParam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label7
            // 
            this.Label7.AccessibleDescription = "Label with text \"Using Stored Procedures\"";
            this.Label7.AccessibleName = "Application Title";
            this.Label7.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label7.Location = new System.Drawing.Point(380, 9);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(249, 23);
            this.Label7.TabIndex = 2;
            this.Label7.Text = "Using Stored Procedures";
            // 
            // btnGet10MostExpProds
            // 
            this.btnGet10MostExpProds.AccessibleDescription = "Button with text \"Get the 10 Most Expensive Products\"";
            this.btnGet10MostExpProds.AccessibleName = "Get the 10 Most Expensive Products";
            this.btnGet10MostExpProds.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGet10MostExpProds.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGet10MostExpProds.Location = new System.Drawing.Point(66, 22);
            this.btnGet10MostExpProds.Name = "btnGet10MostExpProds";
            this.btnGet10MostExpProds.Size = new System.Drawing.Size(240, 23);
            this.btnGet10MostExpProds.TabIndex = 0;
            this.btnGet10MostExpProds.Text = "&Get the 10 Most Expensive Products";
            this.btnGet10MostExpProds.Click += new System.EventHandler(this.btnGet10MostExpProds_Click);
            // 
            // lstTenMostExpProds
            // 
            this.lstTenMostExpProds.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTenMostExpProds.FormattingEnabled = true;
            this.lstTenMostExpProds.ItemHeight = 18;
            this.lstTenMostExpProds.Location = new System.Drawing.Point(12, 82);
            this.lstTenMostExpProds.Name = "lstTenMostExpProds";
            this.lstTenMostExpProds.Size = new System.Drawing.Size(333, 148);
            this.lstTenMostExpProds.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(551, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 36);
            this.button1.TabIndex = 35;
            this.button1.Text = "Insert Record";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(454, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 34;
            this.label8.Text = "Customer Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(454, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(454, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Country";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(454, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(454, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(454, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(454, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "First Name";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(612, 353);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(133, 20);
            this.txtPhone.TabIndex = 27;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(612, 314);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(133, 20);
            this.txtCountry.TabIndex = 26;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(612, 273);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(133, 20);
            this.txtCity.TabIndex = 25;
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(612, 234);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(133, 20);
            this.txtAdd.TabIndex = 24;
            // 
            // txtLN
            // 
            this.txtLN.Location = new System.Drawing.Point(612, 197);
            this.txtLN.Name = "txtLN";
            this.txtLN.Size = new System.Drawing.Size(133, 20);
            this.txtLN.TabIndex = 23;
            // 
            // txtFN
            // 
            this.txtFN.Location = new System.Drawing.Point(612, 160);
            this.txtFN.Name = "txtFN";
            this.txtFN.Size = new System.Drawing.Size(133, 20);
            this.txtFN.TabIndex = 22;
            // 
            // txtCID
            // 
            this.txtCID.Location = new System.Drawing.Point(612, 123);
            this.txtCID.Name = "txtCID";
            this.txtCID.Size = new System.Drawing.Size(133, 20);
            this.txtCID.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(424, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(368, 18);
            this.label9.TabIndex = 20;
            this.label9.Text = "Execute Procedure Using SQLCommand Object";
            // 
            // btnOutputParam
            // 
            this.btnOutputParam.Location = new System.Drawing.Point(94, 271);
            this.btnOutputParam.Name = "btnOutputParam";
            this.btnOutputParam.Size = new System.Drawing.Size(150, 23);
            this.btnOutputParam.TabIndex = 36;
            this.btnOutputParam.Text = "Use Output Parameter";
            this.btnOutputParam.UseVisualStyleBackColor = true;
            this.btnOutputParam.Click += new System.EventHandler(this.btnOutputParam_Click);
            // 
            // Demo02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 507);
            this.Controls.Add(this.btnOutputParam);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.txtLN);
            this.Controls.Add(this.txtFN);
            this.Controls.Add(this.txtCID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnGet10MostExpProds);
            this.Controls.Add(this.lstTenMostExpProds);
            this.Controls.Add(this.Label7);
            this.Name = "Demo02";
            this.Text = "Demo02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label7;
        private System.Windows.Forms.Button btnGet10MostExpProds;
        private System.Windows.Forms.ListBox lstTenMostExpProds;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.TextBox txtLN;
        private System.Windows.Forms.TextBox txtFN;
        private System.Windows.Forms.TextBox txtCID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnOutputParam;

    }
}