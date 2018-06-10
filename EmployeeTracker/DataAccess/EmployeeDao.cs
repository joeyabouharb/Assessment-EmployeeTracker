using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;
namespace DataAccess
{

    public class EmployeeDao

    {
        public void Insert(Employee emp)
        {
            //open connection to db
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnectionHelper.getConnectionString();
            conn.Open();

            using (conn)
            {
               // 2 - set command
                SqlCommand command = new SqlCommand("SP_AddEmployee_Employee", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                //list paramaters
                command.Parameters.Add(new SqlParameter("@FirstName", emp.FirstName));
                command.Parameters.Add(new SqlParameter("@LastName", emp.LastName));
                command.Parameters.Add(new SqlParameter("@Email", emp.EmployeeEmail));
                command.Parameters.Add(new SqlParameter("@DOB", emp.EmployeeDOB));
                command.Parameters.Add(new SqlParameter("@Phone", emp.EmployeePhone));
                //3 - run command
                command.ExecuteNonQuery();
            }

        }

        public void  Update(Employee employee)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnectionHelper.getConnectionString();
            conn.Open();

            using (conn)
            {
                //2 command
                SqlCommand command = new SqlCommand("SP_Employees_UpdateEmployees", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@EmployeeId", employee.EmployeeID));
                command.Parameters.Add(new SqlParameter("@FirstName", employee.FirstName));
                command.Parameters.Add(new SqlParameter("@LastName", employee.LastName));
                command.Parameters.Add(new SqlParameter("@DOB", employee.EmployeeDOB));
                command.Parameters.Add(new SqlParameter("@Email", employee.EmployeeEmail));
                command.Parameters.Add(new SqlParameter("@Phone", employee.EmployeePhone));

                command.ExecuteNonQuery();

            }
        }

        public List<Employee> DisplayEmployees()
        {
            //open connection to db
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnectionHelper.getConnectionString();
            conn.Open();

            using (conn)
            {
                SqlCommand command = new SqlCommand("SP_DisplayEmployees_Employee", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                //run command
                SqlDataReader reader = command.ExecuteReader();

                //create list to map employee details into Employee Objects
                List<Employee> employees = new List<Employee>();

                while (reader.Read())
                {
                    Employee employee = new Employee();
                    employee.EmployeeID = Convert.ToInt32(reader["EmpID"]);
                    employee.FirstName = Convert.ToString(reader["FirstName"]);
                    employee.LastName = Convert.ToString(reader["LastName"]);
                    employee.EmployeeDOB = Convert.ToDateTime(reader["DOB"]).ToString("yyyy/MM/dd");
                    employee.EmployeeEmail = Convert.ToString(reader["Email"]);
                    employee.EmployeePhone = Convert.ToString(reader["Phone"]);
                    employees.Add(employee);

                }
                return employees;

            }
        }

    }
}
