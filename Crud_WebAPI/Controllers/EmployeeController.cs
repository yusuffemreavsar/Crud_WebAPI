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
            await _employeeRepository.AddEmployee(employee);
            return Ok();
        }

    }

}
