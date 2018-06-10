using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Model;
namespace Controller
{
    public class EmpHourController
    {
        private WorkingHourDao dao;

        public EmpHourController()
        {
            dao = new WorkingHourDao();
        }

        public ResultEnum Insert(WorkingHour hour)
        {

            try
            {
                dao.Insert(hour);
                return ResultEnum.Success;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return ResultEnum.Fail;
            }

        }
        public HourResult GetHours(int i)
        {
            HourResult result = new HourResult();

            try
            {
                result.hours = dao.Display(i);
                result.status = ResultEnum.Success;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                result.status = ResultEnum.Fail;
              
            }
            return result;
        }
    }
}
    