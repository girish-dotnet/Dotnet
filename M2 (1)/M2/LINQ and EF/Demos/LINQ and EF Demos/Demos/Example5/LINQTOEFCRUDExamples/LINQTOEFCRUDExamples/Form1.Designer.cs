namespace LINQTOEFCRUDExamples
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.cboDesign = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.btnSearchEmployee = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtDob = new System.Windows.Forms.TextBox();
            this.txtEmailID = new System.Windows.Forms.TextBox();
            this.cboDesignation = new System.Windows.Forms.ComboBox();
            this.btnUpdateEmployee = new System.Windows.Forms.Button();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(769, 515);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(761, 486);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "View All Employees";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnAddEmployee);
            this.tabPage2.Controls.Add(this.txtEmail);
            this.tabPage2.Controls.Add(this.cboDesign);
            this.tabPage2.Controls.Add(this.dtpDOB);
            this.tabPage2.Controls.Add(this.cboGender);
            this.tabPage2.Controls.Add(this.txtLname);
            this.tabPage2.Controls.Add(this.txtFname);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(761, 486);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add Employees";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnDeleteEmployee);
            this.tabPage3.Controls.Add(this.btnUpdateEmployee);
            this.tabPage3.Controls.Add(this.cboDesignation);
            this.tabPage3.Controls.Add(this.txtEmailID);
            this.tabPage3.Controls.Add(this.txtDob);
            this.tabPage3.Controls.Add(this.txtGender);
            this.tabPage3.Controls.Add(this.txtLastName);
            this.tabPage3.Controls.Add(this.txtFirstName);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.btnSearchEmployee);
            this.tabPage3.Controls.Add(this.txtEmpID);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(761, 486);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Update and Delete Employee";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(755, 480);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Designation";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email";
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(254, 48);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(200, 22);
            this.txtFname.TabIndex = 6;
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(254, 94);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(200, 22);
            this.txtLname.TabIndex = 7;
            // 
            // cboGender
            // 
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cboGender.Location = new System.Drawing.Point(254, 147);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(200, 24);
            this.cboGender.TabIndex = 8;
            this.cboGender.Text = "(Select Gender)";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(254, 204);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(200, 22);
            this.dtpDOB.TabIndex = 9;
            // 
            // cboDesign
            // 
            this.cboDesign.FormattingEnabled = true;
            this.cboDesign.Items.AddRange(new object[] {
            "Software Engineer",
            "Sr SW Engineer",
            "Consultant",
            "Senior Consultant",
            "Manager"});
            this.cboDesign.Location = new System.Drawing.Point(254, 264);
            this.cboDesign.Name = "cboDesign";
            this.cboDesign.Size = new System.Drawing.Size(200, 24);
            this.cboDesign.TabIndex = 10;
            this.cboDesign.Text = "(Select)";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(254, 320);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(265, 22);
            this.txtEmail.TabIndex = 11;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(254, 381);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(265, 33);
            this.btnAddEmployee.TabIndex = 12;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Employee ID";
            // 
            // txtEmpID
            // 
            this.txtEmpID.Location = new System.Drawing.Point(247, 58);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(181, 22);
            this.txtEmpID.TabIndex = 1;
            // 
            // btnSearchEmployee
            // 
            this.btnSearchEmployee.Location = new System.Drawing.Point(247, 98);
            this.btnSearchEmployee.Name = "btnSearchEmployee";
            this.btnSearchEmployee.Size = new System.Drawing.Size(181, 28);
            this.btnSearchEmployee.TabIndex = 2;
            this.btnSearchEmployee.Text = "Search Employee";
            this.btnSearchEmployee.UseVisualStyleBackColor = true;
            this.btnSearchEmployee.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(78, 396);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(78, 350);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "Designation";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(78, 296);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "Date of Birth";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(78, 241);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 16);
            this.label11.TabIndex = 8;
            this.label11.Text = "Gender";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(78, 190);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 16);
            this.label12.TabIndex = 7;
            this.label12.Text = "Last Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(78, 139);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 16);
            this.label13.TabIndex = 6;
            this.label13.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(247, 139);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(181, 22);
            this.txtFirstName.TabIndex = 12;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(247, 184);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(181, 22);
            this.txtLastName.TabIndex = 13;
            // 
            // txtGender
            // 
            this.txtGender.Enabled = false;
            this.txtGender.Location = new System.Drawing.Point(247, 235);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(181, 22);
            this.txtGender.TabIndex = 14;
            // 
            // txtDob
            // 
            this.txtDob.Enabled = false;
            this.txtDob.Location = new System.Drawing.Point(247, 290);
            this.txtDob.Name = "txtDob";
            this.txtDob.Size = new System.Drawing.Size(181, 22);
            this.txtDob.TabIndex = 15;
            // 
            // txtEmailID
            // 
            this.txtEmailID.Location = new System.Drawing.Point(247, 390);
            this.txtEmailID.Name = "txtEmailID";
            this.txtEmailID.Size = new System.Drawing.Size(238, 22);
            this.txtEmailID.TabIndex = 16;
            // 
            // cboDesignation
            // 
            this.cboDesignation.FormattingEnabled = true;
            this.cboDesignation.Items.AddRange(new object[] {
            "Software Engineer",
            "Sr SW Engineer",
            "Consultant",
            "Senior Consultant",
            "Manager"});
            this.cboDesignation.Location = new System.Drawing.Point(247, 342);
            this.cboDesignation.Name = "cboDesignation";
            this.cboDesignation.Size = new System.Drawing.Size(181, 24);
            this.cboDesignation.TabIndex = 17;
            // 
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.Location = new System.Drawing.Point(81, 434);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Size = new System.Drawing.Size(199, 34);
            this.btnUpdateEmployee.TabIndex = 18;
            this.btnUpdateEmployee.Text = "Update Employee";
            this.btnUpdateEmployee.UseVisualStyleBackColor = true;
            this.btnUpdateEmployee.Click += new System.EventHandler(this.btnUpdateEmployee_Click);
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Location = new System.Drawing.Point(337, 433);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(210, 35);
            this.btnDeleteEmployee.TabIndex = 19;
            this.btnDeleteEmployee.Text = "Delete Employee";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 539);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cboDesign;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnSearchEmployee;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEmailID;
        private System.Windows.Forms.TextBox txtDob;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.ComboBox cboDesignation;
        private System.Windows.Forms.Button btnUpdateEmployee;
        private System.Windows.Forms.Button btnDeleteEmployee;
    }
}

