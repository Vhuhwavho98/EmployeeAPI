using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAPI.Applications.Employee.Commands.CreateEmployee
{
    public class CreateEmployeeCommand : IRequest<EmployeeVm>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmpCode { get; set; }
        public string Position { get; set; }
        public string Office { get; set; }
    }
}
