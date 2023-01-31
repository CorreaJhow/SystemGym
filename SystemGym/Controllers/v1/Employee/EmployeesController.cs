using Microsoft.AspNetCore.Mvc;
using SystemGym.Application.Services.Interfaces;

namespace SystemGym.Controllers.v1.Employee
{
    [Route("api/v1/Employees")]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

        [HttpGet("{Id}")]
        public IActionResult GetByDocument(string document)
        {

            return Ok();
        }

        [HttpPost]
        public IActionResult RegisterEmployee([FromBody] string employee) //criar employee 
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdatePositionEmployee([FromBody] string employee)
        {
            //verificar se employee existe em banco de dados, se sim atualizar dados, se nao retornar erro
            return Ok();

        }

        [HttpDelete]
        public IActionResult DeleteEmployeeById([FromBody] string id) //criar deleteEmployee
        {
            //verificar se employee existe em banco de dados, se sim atualizar dados, se nao retornar erro
            return Ok();

        }


    }
}
