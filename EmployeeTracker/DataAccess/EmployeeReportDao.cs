using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;
namespace DataAccess
{
    public class EmployeeReportDao
    {
        public List<EmployeeReport> GenerateReport()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnectionHelper.getConnectionString();
            conn.Open();

            using (conn)
            {
                SqlCommand command = new SqlCommand("SP_EmployeeReport", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                
                SqlDataReader reader = command.ExecuteReader();
                List<EmployeeReport> reportList = new List<EmployeeReport>();
                
                while (reader.Read())
                {
                    EmployeeReport report = new EmployeeReport();
                    report.EmpID = Convert.ToInt32(reader["EmpID"]);
                    report.FirstName = Convert.ToString(reader["FirstName"]);
                    report.LastName = Convert.ToString(reader["LastName"]);
                    report.TotalHours = Convert.ToDouble(reader["TotalHoursWorked"]);

                    reportList.Add(report);
                }
                return reportList;
            }
        }
    }
}
