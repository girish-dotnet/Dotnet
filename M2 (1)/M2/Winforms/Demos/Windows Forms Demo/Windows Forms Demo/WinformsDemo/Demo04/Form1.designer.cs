namespace Demo04
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private static Form1 instance = null;
        public static Form1 GetInstance()
        {
            if (instance == null)
                instance = new Form1();
            return instance;

        }
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
            instance = null;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddNumbers = new System.Windows.Forms.Button();
            this.txtSecondNumber = new System.Windows.Forms.TextBox();
            this.txtFirstNumber = new System.Windows.Forms.TextBox();
            this.lblSecondNumber = new System.Windows.Forms.Label();
            this.lblFirstNumber = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnShowEmployee = new System.Windows.Forms.Button();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnShowStudentDetails = new System.Windows.Forms.Button();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddNumbers);
            this.groupBox1.Controls.Add(this.txtSecondNumber);
            this.groupBox1.Controls.Add(this.txtFirstNumber);
            this.groupBox1.Controls.Add(this.lblSecondNumber);
            this.groupBox1.Controls.Add(this.lblFirstNumber);
            this.groupBox1.Location = new System.Drawing.Point(17, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AddNumbers";
            // 
            // btnAddNumbers
            // 
            this.btnAddNumbers.Location = new System.Drawing.Point(110, 106);
            this.btnAddNumbers.Name = "btnAddNumbers";
            this.btnAddNumbers.Size = new System.Drawing.Size(137, 24);
            this.btnAddNumbers.TabIndex = 4;
            this.btnAddNumbers.Text = "Add";
            this.btnAddNumbers.UseVisualStyleBackColor = true;
            this.btnAddNumbers.Click += new System.EventHandler(this.btnAddNumbers_Click);
            // 
            // txtSecondNumber
            // 
            this.txtSecondNumber.Location = new System.Drawing.Point(102, 68);
            this.txtSecondNumber.Name = "txtSecondNumber";
            this.txtSecondNumber.Size = new System.Drawing.Size(226, 20);
            this.txtSecondNumber.TabIndex = 3;
            // 
            // txtFirstNumber
            // 
            this.txtFirstNumber.Location = new System.Drawing.Point(100, 31);
            this.txtFirstNumber.Name = "txtFirstNumber";
            this.txtFirstNumber.Size = new System.Drawing.Size(228, 20);
            this.txtFirstNumber.TabIndex = 2;
            // 
            // lblSecondNumber
            // 
            this.lblSecondNumber.AutoSize = true;
            this.lblSecondNumber.Location = new System.Drawing.Point(4, 71);
            this.lblSecondNumber.Name = "lblSecondNumber";
            this.lblSecondNumber.Size = new System.Drawing.Size(90, 13);
            this.lblSecondNumber.TabIndex = 1;
            this.lblSecondNumber.Text = "Second Number :";
            // 
            // lblFirstNumber
            // 
            this.lblFirstNumber.AutoSize = true;
            this.lblFirstNumber.Location = new System.Drawing.Point(22, 34);
            this.lblFirstNumber.Name = "lblFirstNumber";
            this.lblFirstNumber.Size = new System.Drawing.Size(72, 13);
            this.lblFirstNumber.TabIndex = 0;
            this.lblFirstNumber.Text = "FirstNumber : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnShowEmployee);
            this.groupBox2.Controls.Add(this.txtEmployeeName);
            this.groupBox2.Controls.Add(this.txtEmployeeID);
            this.groupBox2.Controls.Add(this.lblEmployeeName);
            this.groupBox2.Controls.Add(this.lblEmployeeID);
            this.groupBox2.Location = new System.Drawing.Point(17, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 151);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enter Employee Details";
            // 
            // btnShowEmployee
            // 
            this.btnShowEmployee.Location = new System.Drawing.Point(105, 110);
            this.btnShowEmployee.Name = "btnShowEmployee";
            this.btnShowEmployee.Size = new System.Drawing.Size(176, 31);
            this.btnShowEmployee.TabIndex = 4;
            this.btnShowEmployee.Text = "Show Employee Details";
            this.btnShowEmployee.UseVisualStyleBackColor = true;
            this.btnShowEmployee.Click += new System.EventHandler(this.btnShowEmployee_Click);
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(114, 74);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(215, 20);
            this.txtEmployeeName.TabIndex = 3;
            this.txtEmployeeName.TextChanged += new System.EventHandler(this.txtEmployeeName_TextChanged);
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(113, 36);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(215, 20);
            this.txtEmployeeID.TabIndex = 2;
            this.txtEmployeeID.TextChanged += new System.EventHandler(this.txtEmployeeID_TextChanged);
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(60, 77);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(41, 13);
            this.lblEmployeeName.TabIndex = 1;
            this.lblEmployeeName.Text = "Name :";
            this.lblEmployeeName.Click += new System.EventHandler(this.lblEmployeeName_Click);
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(31, 39);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(70, 13);
            this.lblEmployeeID.TabIndex = 0;
            this.lblEmployeeID.Text = "EmployeeID :";
            this.lblEmployeeID.Click += new System.EventHandler(this.lblEmployeeID_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnShowStudentDetails);
            this.groupBox3.Controls.Add(this.txtStudentName);
            this.groupBox3.Controls.Add(this.txtStudentID);
            this.groupBox3.Controls.Add(this.lblStudentName);
            this.groupBox3.Controls.Add(this.lblStudentID);
            this.groupBox3.Location = new System.Drawing.Point(19, 347);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(355, 132);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Enter Student Details";
            // 
            // btnShowStudentDetails
            // 
            this.btnShowStudentDetails.Location = new System.Drawing.Point(103, 96);
            this.btnShowStudentDetails.Name = "btnShowStudentDetails";
            this.btnShowStudentDetails.Size = new System.Drawing.Size(165, 30);
            this.btnShowStudentDetails.TabIndex = 4;
            this.btnShowStudentDetails.Text = "Show Student Details";
            this.btnShowStudentDetails.UseVisualStyleBackColor = true;
            this.btnShowStudentDetails.Click += new System.EventHandler(this.btnShowStudentDetails_Click);
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(105, 63);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(219, 20);
            this.txtStudentName.TabIndex = 3;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(105, 30);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(219, 20);
            this.txtStudentID.TabIndex = 2;
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(48, 66);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(44, 13);
            this.lblStudentName.TabIndex = 1;
            this.lblStudentName.Text = "Name : ";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(30, 33);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(67, 13);
            this.lblStudentID.TabIndex = 0;
            this.lblStudentID.Text = "Student ID : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 510);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Delegates and Events";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSecondNumber;
        private System.Windows.Forms.TextBox txtFirstNumber;
        private System.Windows.Forms.Label lblSecondNumber;
        private System.Windows.Forms.Label lblFirstNumber;
        private System.Windows.Forms.Button btnAddNumbers;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnShowEmployee;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnShowStudentDetails;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblStudentID;
    }
}