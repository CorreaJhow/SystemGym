using Microsoft.AspNetCore.Mvc;
using SystemGym.Application.InputModels.v1.Client;
using SystemGym.Application.Services.Contracts;

namespace SystemGym.Controllers.v1.Client
{
    [Route("api/v1/Clients")]
    public class ClientsController : ControllerBase
    {
        private readonly IClientService _clientService;
        public ClientsController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var clients = _clientService.GetAll();

            if (clients is null)
                return NotFound("Error Message: There are no registered customers");

            return Ok(clients);
        }

        [HttpGet("{document}")]
        public IActionResult GetByDocument(string document)
        {
            var client = _clientService.GetByDocument(document);

            if (client is null)
                return NotFound("There are no customers registered with this document");

            return Ok(client);
        }

        [HttpPost]
        public IActionResult RegisterClient([FromBody] NewClientInputModel inputClient) 
        {
            _clientService.RegisterClient(inputClient);

            return Ok("Successfully registered customer");
        }

        [HttpPut]
        public IActionResult UpdateClient(string document, [FromBody] UpdateClientInputModel inputClient)
        {
            _clientService.UpdateClient(document, inputClient);

            return Ok("Client updated successfully");
        }

        [HttpDelete]
        public IActionResult DeleteClient([FromBody] DeleteClientInputModel inputClient)
        {
            _clientService.DeleteClient(inputClient);

            return Ok("Customer deleted successfully");
        }
    }
}
