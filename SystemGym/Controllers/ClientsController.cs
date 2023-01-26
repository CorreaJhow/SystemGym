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
        public IActionResult GetByDocument(string document)
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
        public IActionResult DeleteClient([FromBody] string document) //criar deleteEmployee
        {
            //verificar se employee existe em banco de dados, se sim atualizar dados, se nao retornar erro
            return Ok();
        }
    }
}
