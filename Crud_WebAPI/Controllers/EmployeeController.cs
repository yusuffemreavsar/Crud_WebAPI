using Crud_WebAPI.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Crud_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private EmployeeRepository _employeeRepository;
        public EmployeeController(EmployeeRepository employeeRepository)
        {
            this._employeeRepository = employeeRepository;  
        }

        [HttpPost]
        public async Task<ActionResult> AddEmployee([FromBody]Employee employee)
        {
            await _employeeRepository.AddEmployeeAsync(employee);
            return Ok("Employee Added.");
        }
        [HttpGet]
        public async Task<ActionResult> GetAllEmployee()
        {
            List<Employee> employeeList=await _employeeRepository.GetAllEmployeeAsync();
            return Ok(employeeList);
        } 
        [HttpGet("{id}")]
        public async Task<ActionResult> GetEmployeeById([FromRoute]int id)
        {
            var employee=await _employeeRepository.GetEmployeeByIdAsync(id);
            return Ok(employee);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateEmployee([FromRoute]int id, [FromBody]Employee employee)
        {
            await _employeeRepository.UpdateEmployeeAsync(id, employee);
            return Ok(id +" "+"Employee is updated.");
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteEmployee([FromRoute]int id)
        {
            await _employeeRepository.DeleteEmployeeAsync(id);
            return Ok(id+" "+"Employee is deleted.");
        }

    }

}
