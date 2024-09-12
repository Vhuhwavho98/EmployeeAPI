using AutoMapper;
using EmployeeAPI.Domain.IRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAPI.Applications.Employee.Queries.GetAllEmployees
{
    public class GetAllEmployeesQueryHandler : IRequestHandler<GetAllEmployeesQuery, List<EmployeeVm>>
    {
        private readonly IMapper _mapper;
        private readonly IEmployeeRepository _employeeRepository;
        public GetAllEmployeesQueryHandler(IMapper mapper, IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;    
        }
        public async Task<List<EmployeeVm>> Handle(GetAllEmployeesQuery request, CancellationToken cancellationToken)
        {
            var employees = await _employeeRepository.GetAllAsync();
            return _mapper.Map<List<EmployeeVm>>(employees);

        }
    }
}
