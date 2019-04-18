using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo04
{
    public class AppEvents
    {
        public static event CalculationHandler AddEvent = null;
        public static event DisplayEmployeeHandler ShowEmployeeEvent = null;
        public static event EventHandler ShowStudentEvent = null;

        public static void OnAddEvent(int firstNumber,int secondNumber)
        {
            if (AddEvent != null)
                AddEvent(firstNumber, secondNumber);
        }

        public static void OnShowEmployeeEvent(Employee employee)
        {
            if (ShowEmployeeEvent != null)
                ShowEmployeeEvent(employee);
        }

        public static void OnShowStudentEvent(object sender, EventArgs e)
        {
            if (ShowStudentEvent != null)
                ShowStudentEvent(sender, e);
        }
    }
}
