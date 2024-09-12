using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAPI.Applications.Employee.Commands.DeleteEmployee
{
    public class DeleteEmployeeCommand : IRequest<int>
    {
        public int EmployeeID { get; set; }
    }
}
