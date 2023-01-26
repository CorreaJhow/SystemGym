using Microsoft.AspNetCore.Mvc;

namespace SystemGym.Controllers
{
    [Route("api/v1/Employees")]
    public class EmployeesController : ControllerBase
    {
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
        public IActionResult UpdateEmployee([FromBody] string employee)
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
