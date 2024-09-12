using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAPI.Applications.Employee
{
    public class EmployeeVm
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmpCode { get; set; }
        public string Position { get; set; }
        public string Office { get; set; }
    }
}
