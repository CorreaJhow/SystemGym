using System.Collections.Generic;
using System.Linq;
using SystemGym.Application.InputModels.v1.Client;
using SystemGym.Application.Services.Contracts;
using SystemGym.Application.ViewModels.v1.Client;
using SystemGym.Domain.Entities.v1.Client;
using SystemGym.Infrastructure.Persistence;

namespace SystemGym.Application.Services.Implementations
{
    public class ClientService : IClientService
    {
        private readonly SystemGymDbContext _dbContext;
        public ClientService(SystemGymDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int RegisterClient(NewClientInputModel newClient)
        {
            var client = new Client(newClient.Name, newClient.Age, newClient.Phone, newClient.Document);

            _dbContext.Client.Add(client);

            return client.Id;
        }

        public void DeleteClient(DeleteClientInputModel deleteClient)
        {
            var list = _dbContext.Client.ToList();
            foreach (var client in list)
            {
                if (deleteClient.Document == client.Document)
                {
                    _dbContext.Client.Remove(client);
                }
            }
        }

        public List<ClientViewModel> GetAll()
        {
            var clients = _dbContext.Client;

            var clientVieModels = clients.Select(c => new ClientViewModel(c.Name, c.Age, c.Phone, c.Active,c.Document)).ToList();

            return clientVieModels;
        }

        public ClientDetailsViewModels GetByDocument(string document)
        {
            var client = _dbContext.Client.FirstOrDefault(c => c.Document.Equals(document));

            if (client is null)
                return null;

            return new ClientDetailsViewModels(client.Name, client.Age, client.Phone, client.Document, client.Email, client.Active, client.RegistrationDate);

        }

        public void UpdateClient(string document, UpdateClientInputModel updateClient)
        {
            var client = _dbContext.Client.FirstOrDefault(c => c.Document.Equals(document));

            if (client is null)
                return;

            _dbContext.Client.Remove(client);

            _dbContext.Client.Add(new Client(updateClient.Name, updateClient.Age, updateClient.Phone, updateClient.Document, updateClient.Email));
        }
    }
}
