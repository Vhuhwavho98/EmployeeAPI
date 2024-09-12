using EmployeeAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAPI.Domain.IRepository
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetAllAsync();
        Task<Employee> GetByIdAsync(int id);
        Task<Employee> CreateEmployeeAsync(Employee employee);
        Task<int> UpdateEmployeeAsync(Employee employee,int id);
        Task<int> DeleteEmployeeAsync(int id);
    }
}
