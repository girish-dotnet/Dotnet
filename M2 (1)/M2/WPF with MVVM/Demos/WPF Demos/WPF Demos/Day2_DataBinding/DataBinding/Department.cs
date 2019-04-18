using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace DataBinding
{
    public class Department : INotifyPropertyChanged
    {
        private int departmentID = 101;
        private string departmentName = "India Learning Academy";

        public int DepartmentID
        {
            get { return departmentID; }
            set { departmentID = value; OnPropertyChanged("DepartmentDetails"); }
        }

        public string DepartmentName
        {
            get { return departmentName; }
            set { departmentName = value; OnPropertyChanged("DepartmentDetails"); }
        }

        public string DepartmentDetails
        {
            get
            {
                return string.Format("{0} {1}", departmentID, departmentName);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
    }
}
