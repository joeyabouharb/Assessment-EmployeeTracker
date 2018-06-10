using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace Controller
{
    public class HourResult
    {
        public List<WorkingHour> hours { get; set; }

        public ResultEnum status { get; set; }
    }
}
