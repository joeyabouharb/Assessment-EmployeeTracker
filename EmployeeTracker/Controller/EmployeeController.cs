using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Model;
namespace Controller
{
    public class EmployeeController
    {
        private EmployeeDao dao;

            public EmployeeController()
        {
            dao = new EmployeeDao();
        }

        public ResultEnum Add(Employee emp)
        {
            try
            {
                dao.Insert(emp);
                return ResultEnum.Success;
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return ResultEnum.Fail;
        }

        public ResultEnum UpdateEmployee(Employee employee)
        {
            try
            {
                dao.Update(employee);
                return ResultEnum.Success;
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return ResultEnum.Fail;
            }
        } 


        public Result GetEmployeeList()
        {
            Result employeeList = new Result();
            try
            {
                employeeList.Data = dao.DisplayEmployees();
                employeeList.Status = ResultEnum.Success;
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                employeeList.Status = ResultEnum.Fail;
            }
            return employeeList;
    }
    }

   
}
