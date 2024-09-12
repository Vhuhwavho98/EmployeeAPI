using EmployeeAPI.Domain.IRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAPI.Applications.Employee.Commands.DeleteEmployee
{
    public class DeleteEmployeeCommandHandler : IRequestHandler<DeleteEmployeeCommand, int>
    {
        private readonly IEmployeeRepository _employeeRepository;
        public DeleteEmployeeCommandHandler(IEmployeeRepository employeeRepository  )
        {
            _employeeRepository = employeeRepository;
        }
        public async Task<int> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
            return await _employeeRepository.DeleteEmployeeAsync(request.EmployeeID);
        }
    }
}
