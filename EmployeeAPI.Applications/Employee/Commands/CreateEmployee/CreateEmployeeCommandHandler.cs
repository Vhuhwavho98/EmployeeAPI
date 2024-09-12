using AutoMapper;
using EmployeeAPI.Domain.IRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAPI.Applications.Employee.Commands.CreateEmployee
{
    public class CreateEmployeeCommandHandler : IRequestHandler<CreateEmployeeCommand, EmployeeVm>
    {
        private readonly IMapper _mapper;
        private readonly IEmployeeRepository _employeeRepository;
        public CreateEmployeeCommandHandler(IMapper mapper,IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }
        public async Task<EmployeeVm> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = new Domain.Entities.Employee() {
                EmpCode = request.EmpCode,
                FirstName = request.FirstName,
                LastName = request.LastName,
                Office = request.Office,
                Position = request.Position,
            
            };

            var results = await _employeeRepository.CreateEmployeeAsync(employee);
            return _mapper.Map<EmployeeVm>(results);    

        }
    }
}
