using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirstApproachEx
{

    class EmployeeContext :DbContext 
    {
        public EmployeeContext() : base() { }

        //EntitySet
        public DbSet<Employee> Employees { get; set; }
    }

    //DBContext
    //A DbContext instance represents a combination of the Unit Of Work and Repository patterns 
    //such that it can be used to query from a database and group together changes
    //that will then be written back to the store as a unit. 

}
