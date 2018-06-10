using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace Controller
{
    public class Result
    {
        public ResultEnum Status { get; set; }

        public List<Employee> Data { get; set; }


    }
}
