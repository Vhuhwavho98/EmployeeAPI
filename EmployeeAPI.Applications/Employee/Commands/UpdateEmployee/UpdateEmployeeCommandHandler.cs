using EmployeeAPI.Domain.IRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAPI.Applications.Employee.Commands.UpdateEmployee
{
    public class UpdateEmployeeCommandHandler : IRequestHandler<UpdateEmployeeCommand, int>
    {
        private readonly IEmployeeRepository _employeeRepository;
        public UpdateEmployeeCommandHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;   
        }
        public async Task<int> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = new Domain.Entities.Employee()
            {
                EmpCode = request.EmpCode,
                FirstName = request.FirstName,
                LastName = request.LastName,
                Office = request.Office,
                Position = request.Position,

            };

            return await _employeeRepository.UpdateEmployeeAsync(employee, request.EmployeeID);
        }
    }
}
