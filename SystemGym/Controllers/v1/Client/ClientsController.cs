using Microsoft.AspNetCore.Mvc;
using SystemGym.Application.InputModels.v1.Client;
using SystemGym.Application.Services.Interfaces;
using SystemGym.Domain.Entities.v1.Client;

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

        [HttpGet("{Documents}")]
        public IActionResult GetByDocument(string document)
        {
            var client = _clientService.GetByDocument(document);

            if (client is null)
                return NotFound("There are no customers registered with this document");

            return Ok(client);
        }

        [HttpPost]
        public IActionResult RegisterClient([FromBody] NewClientInputModel inputClient) //criar employee 
        {
            _clientService.RegisterClient(inputClient);

            return Ok("Successfully registered customer");
        }

        [HttpPut("{Nutritionist}")]
        public IActionResult UpdateNutritionistClient([FromBody] UpdateNutritionistClientInputModel inputClient)
        {
            _clientService.UpdateNutritionistClient(inputClient);

            return Ok("Benefit \"Nutritionist\" updated successfully");

        }

        [HttpPut("{VIP}")]
        public IActionResult UpdateVIPClient([FromBody] UpdateVIPClientInputModel inputClient)
        {
            _clientService.UpdateVIPClient(inputClient);

            return Ok("Benefit \"VIP\" updated successfully");

        }

        [HttpPut]
        public IActionResult UpdateClient([FromBody] UpdateClientInputModel inputClient)
        {
            _clientService.UpdateClient(inputClient);

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
