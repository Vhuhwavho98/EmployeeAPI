using EmployeeAPI.Applications.Employee.Queries.GetAllEmployees;
using EmployeeAPI.Applications.Employee.Queries.GetEmployeeById;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeeController : BaseController
    {

        [HttpGet]
        public async Task<IActionResult> GetAllEmployees()
        {
            var employees = await Mediator.Send(new GetAllEmployeesQuery());

            if(employees == null)
            {
                return NotFound();
            }
            return Ok(employees);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployeeById(int id)
        {
            var employee = await Mediator.Send(new GetEmployeeByIdQuery() { EmployeeID = id});

            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }
    }
}
