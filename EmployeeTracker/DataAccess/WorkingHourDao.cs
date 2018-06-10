using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;
namespace DataAccess
{
    public class WorkingHourDao
    {
        public void Insert(WorkingHour hour)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnectionHelper.getConnectionString();
            conn.Open();

            using (conn)
            {
                SqlCommand command = new SqlCommand("SP_ADDHOURS_EmpHours", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@EmpID", hour.EmpID));
                command.Parameters.Add(new SqlParameter("@WorkDate", hour.WorkDate));
                command.Parameters.Add(new SqlParameter("@Hours", hour.Hours));

                command.ExecuteNonQuery();
            }

        }
        public List<WorkingHour> Display(int i)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnectionHelper.getConnectionString();
            conn.Open();

            using (conn)
            {
                SqlCommand command = new SqlCommand("SP_EmployeeHours", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@empid", i));
                SqlDataReader reader = command.ExecuteReader();
                List<WorkingHour> workingHours = new List<WorkingHour>();

                while (reader.Read())
                {
                    WorkingHour workingHour = new WorkingHour();
                    workingHour.WorkingHoursID = Convert.ToInt32(reader["empHoursID"]);
                    workingHour.EmpID = i;
                    workingHour.Hours = Convert.ToInt32(reader["Hours"]);
                    workingHour.WorkDate = Convert.ToDateTime(reader["WorkDate"]).ToString("yyyy-MM-dd");

                    workingHours.Add(workingHour);
                }
                return workingHours;
            }



        }
    }
}
