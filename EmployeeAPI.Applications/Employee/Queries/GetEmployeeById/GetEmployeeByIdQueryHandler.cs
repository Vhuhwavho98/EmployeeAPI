using AutoMapper;
using EmployeeAPI.Domain.IRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAPI.Applications.Employee.Queries.GetEmployeeById
{
    public class GetEmployeeByIdQueryHandler : IRequestHandler<GetEmployeeByIdQuery, EmployeeVm>
    {
        private readonly IMapper _mapper;
        private readonly IEmployeeRepository _employeeRepository;
        public GetEmployeeByIdQueryHandler(IEmployeeRepository employeeRepository,IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
            
        }
        public async Task<EmployeeVm> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
        {
            var employee = await _employeeRepository.GetByIdAsync(request.EmployeeID);
            return _mapper.Map<EmployeeVm>(employee);
        }
    }
}
