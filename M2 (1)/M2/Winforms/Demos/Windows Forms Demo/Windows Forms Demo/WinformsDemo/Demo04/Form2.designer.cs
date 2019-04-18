namespace Demo04
{
    public partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private static Form2 instance = null;

        public static Form2 GetInstance()
        {
            if (instance == null)
                instance = new Form2();
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
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
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
            this.groupBox1.Controls.Add(this.txtResult);
            this.groupBox1.Controls.Add(this.lblResult);
            this.groupBox1.Location = new System.Drawing.Point(20, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 76);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Addition Result";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(70, 29);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(220, 20);
            this.txtResult.TabIndex = 1;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(18, 32);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(46, 13);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "Result : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtEmployeeName);
            this.groupBox2.Controls.Add(this.txtEmployeeID);
            this.groupBox2.Controls.Add(this.lblName);
            this.groupBox2.Controls.Add(this.lblEmployeeID);
            this.groupBox2.Location = new System.Drawing.Point(20, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 121);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Show Employee Details";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(114, 74);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(215, 20);
            this.txtEmployeeName.TabIndex = 3;
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(114, 36);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(215, 20);
            this.txtEmployeeID.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(60, 77);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name :";
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(31, 39);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(70, 13);
            this.lblEmployeeID.TabIndex = 0;
            this.lblEmployeeID.Text = "EmployeeID :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtStudentName);
            this.groupBox3.Controls.Add(this.txtStudentID);
            this.groupBox3.Controls.Add(this.lblStudentName);
            this.groupBox3.Controls.Add(this.lblStudentID);
            this.groupBox3.Location = new System.Drawing.Point(22, 263);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(355, 104);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Student Details";
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 394);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Display Screen";
            this.Load += new System.EventHandler(this.Form2_Load);
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
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblStudentID;
    }
}