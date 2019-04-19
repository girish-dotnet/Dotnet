using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4new
{
    public class AppEvents
    {
        public static event DisplayEmployeeHandler ShowEmployeeEvent = null;

        public static event DisplayStudentHandler ShowStudentEvent = null;

        public static void OnShowStudentEvent(Student student)
        {
            if (ShowStudentEvent != null)
                ShowStudentEvent(student);
        }
        public static void OnShowEmployeeEvent(Employee employee)
        {
            if (ShowEmployeeEvent != null)
                ShowEmployeeEvent(employee);
        }
    }
}
