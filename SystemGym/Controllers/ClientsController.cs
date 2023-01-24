using Microsoft.AspNetCore.Mvc;

namespace SystemGym.Controllers
{
    [Route("api/v1/Clients")]
    public class ClientsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

        [HttpGet("{Id}")]
        public IActionResult GetById(string id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult RegisterClient([FromBody] string employee) //criar employee 
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateClient([FromBody] string employee)
        {
            //verificar se employee existe em banco de dados, se sim atualizar dados, se nao retornar erro
            return Ok();

        }

        [HttpDelete]
        public IActionResult DeleteClientById([FromBody] string id) //criar deleteEmployee
        {
            //verificar se employee existe em banco de dados, se sim atualizar dados, se nao retornar erro
            return Ok();
        }
    }
}
