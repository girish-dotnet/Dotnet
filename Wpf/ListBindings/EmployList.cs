using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListBindings
{
    public class EmployList
    {
        List<Employ> lstEmploy = new List<Employ>()
        {
            new Employ{Empno=1,Name="Arun",Basic=88432},
            new Employ{Empno=2,Name="Bharath",Basic=52355},
            new Employ{Empno=3,Name="Tamil",Basic=23677},
            new Employ{Empno=4,Name="Nishanth",Basic=65344},
            new Employ{Empno=5,Name="Sada",Basic=67344},
        };

        public List<Employ> GetEmploy()
        {
            return lstEmploy;
        }
    }
}
