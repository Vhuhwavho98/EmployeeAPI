using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAPI.Applications.Employee.Queries.GetAllEmployees
{
    public class GetAllEmployeesQuery : IRequest<List<EmployeeVm>>
    {
    }
}
