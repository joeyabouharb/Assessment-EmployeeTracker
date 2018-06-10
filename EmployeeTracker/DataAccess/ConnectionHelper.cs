using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ConnectionHelper
    {
        public static string getConnectionString()
        { 
            return "Data Source=(localdb)\\ProjectsV13;Initial Catalog=EmployeeDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }
    }
}
