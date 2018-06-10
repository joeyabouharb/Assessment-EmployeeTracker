using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public enum EmployeeError { success, dateError, nullError, spaceError, nameError, PhoneError, EmailError}
    public class Employee
    {
        private int employeeID;
        private string firstName;
        private string lastName;
        private string employeeEmail;
        private string employeeDOB;
        private string employeePhone;


        public int EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }

        public string FirstName { get { return firstName; } set { firstName = value; } }

        public string LastName { get { return lastName; } set { lastName = value; } }

        public string EmployeeEmail { get { return employeeEmail; } set { employeeEmail = value; } }

        public string EmployeeDOB { get { return employeeDOB; } set { employeeDOB = value; } }

        public string EmployeePhone { get { return employeePhone; } set { employeePhone = value; } }

        public override string ToString()
        {
            return employeeID + ", " + firstName + ", " + lastName + ", " + employeeEmail + ", " + employeeDOB + ", " + employeePhone;
        }

       
    }
}
