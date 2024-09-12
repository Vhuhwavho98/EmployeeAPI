using EmployeeAPI.Domain.Entities;
using EmployeeAPI.Domain.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAPI.Infrastructure.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public Task<Employee> CreateEmployeeAsync(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteEmployeeAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Employee>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateEmployeeAsync(Employee employee, int id)
        {
            throw new NotImplementedException();
        }
    }
}
