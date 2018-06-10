using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace Controller
{
    public class Report
    {
        public ResultEnum Status { get; set; }

       public List<EmployeeReport> EmpReport { get; set; }
    }
}
