using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQtoEFExample
{
    public partial class Form1 : Form
    {
        TrainingEntities trainingContext;

        public Form1()
        {
            InitializeComponent();

            trainingContext = new TrainingEntities();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Display all the records from Staff_Master table
            var query = from staff in trainingContext.Staff_Master
                        select staff;

            dataGridView1.DataSource = query.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Display all the records from Student_Master table
            var query = from student in trainingContext.Student_master
                        select student;

            dataGridView1.DataSource = query.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Display all the records from Book_Master table
            var query = from book in trainingContext.Book_Master
                        select book;

            dataGridView1.DataSource = query.ToList();
        }   

        private void button4_Click(object sender, EventArgs e)
        {
            //Display Average salary for all the staff
            var query = (from staff in trainingContext.Staff_Master
                         select staff.Salary).Average();

            
            MessageBox.Show("Average Salary = "+ query.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Display Maximum salary from the staff
            var query = (from staff in trainingContext.Staff_Master
                         select staff.Salary).Max();

            MessageBox.Show("Maximum Salary = "+query.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Display Minimum salary from the staff
            var query = (from staff in trainingContext.Staff_Master
                         select staff.Salary).Min();

            MessageBox.Show("Minimum Salary = "+query.ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Display the total count of the staff
            var query = (from staff in trainingContext.Staff_Master
                         select staff.Salary).Count();

            MessageBox.Show("Employee Count = "+query.ToString());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Display the Average salary of staff based on Department
            var query = from staff in trainingContext.Staff_Master
                        group staff by staff.Dept_Code into s
                       select new 
                       {
                            Dept_Code = s.Key,
                            AverageSalary = s.Average(staff => staff.Salary)
                       };

            dataGridView1.DataSource = query.ToList();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Display the Maximum salary of staff based on department
            var query = from staff in trainingContext.Staff_Master
                        group staff by staff.Dept_Code into s
                        select new
                        {
                            Dept_Code = s.Key,
                            MaximumSalary = s.Max(staff => staff.Salary)
                        };

            dataGridView1.DataSource = query.ToList();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //Display the Minimum salary of staff based on department
            var query = from staff in trainingContext.Staff_Master
                        group staff by staff.Dept_Code into s
                        select new
                        {
                            Dept_Code = s.Key,
                            MinimumSalary = s.Min(staff => staff.Salary)
                        };

            dataGridView1.DataSource = query.ToList();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //Display the count of staff based on department
            var query = from staff in trainingContext.Staff_Master
                        group staff by staff.Dept_Code into s
                        select new
                        {
                            Dept_Code = s.Key,
                            EmployeeCount = s.Count()
                        };

            dataGridView1.DataSource = query.ToList();
        }
    }
}
