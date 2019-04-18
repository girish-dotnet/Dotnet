using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace INotifyPropertyChangedApp
{
    public class Person:INotifyPropertyChanged
    {
        private string firstName="Nachiket";
        private string lastName="Inamdar";

        public string FirstName 
        { 
            get{return firstName;}
            set { firstName = value; OnPropertyChanged("FullName"); }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; OnPropertyChanged("FullName");}
        }

        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", firstName, lastName);
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
