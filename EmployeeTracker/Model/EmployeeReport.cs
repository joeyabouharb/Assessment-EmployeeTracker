using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class EmployeeReport
    {
        private int empID;
        private string firstName;
        private string lastName;
        private double totalHours;

       public int EmpID { get { return empID; } set { empID = value; } }
        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public double TotalHours { get { return totalHours; } set { totalHours = value; } }

        public override string ToString()
        {
            return empID + ", " + firstName + ", " + lastName + ", " + totalHours;
        }
    }
}
