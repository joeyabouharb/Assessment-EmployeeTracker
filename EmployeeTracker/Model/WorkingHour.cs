using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public enum hourError { dateError, hourError, Success, nullError, spaceError }
    public class WorkingHour
    {
        private int workingHoursID;
        private int empID;
        private string workDate;
        private double hours;

        public int WorkingHoursID { get { return workingHoursID; } set { workingHoursID = value; } }
        public int EmpID { get { return empID; } set { empID = value; } }
        public string WorkDate { get { return workDate; } set { workDate = value; } }
        public double Hours { get { return hours; } set { hours = value; } }


        public override string ToString()
        {
            return empID + ", " + workDate + ", " + hours;
        }

    }
}
