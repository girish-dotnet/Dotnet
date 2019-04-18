using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstApproachEx
{
    //This class will act as an entity for our domain 
    //which will in turn create a database table 
    //when executed
    class Employee
    {
        public int ID { get; set; }//this is will the primary key in the table as the data type is integer identity will applied on this field         
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public string Designation { get; set; }
    }
}
