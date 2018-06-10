using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DataAccess;
namespace Controller
{
    public class EmpReportController
    {
        private EmployeeReportDao dao;

        public EmpReportController()
        {
            dao = new EmployeeReportDao();
        }

        public Report GetReport()
        {
            Report report = new Report();
            try
            {
                report.EmpReport = dao.GenerateReport();
                report.Status = ResultEnum.Success;
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                report.Status = ResultEnum.Fail;

            }
            return report;
        }
    }
}
