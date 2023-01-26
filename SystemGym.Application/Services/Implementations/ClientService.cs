using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemGym.Application.InputModels.v1.Client;
using SystemGym.Application.Services.Interfaces;
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
                if(deleteClient.Document == client.Document)
                {
                    _dbContext.Client.Remove(client);
                }
            }
        }

        public List<ClientViewModel> GetAll()
        {
            var clients =_dbContext.Client;

            var clientVieModels = clients.Select(c => new ClientViewModel(c.Name,c.Age,c.Phone,c.Active)).ToList();  

            return clientVieModels;
        }

        public ClientViewModel GetByDocument(string document)
        {
            throw new NotImplementedException();
        }

        public void UpdateVIPClient(UpdateVIPClientInputModel UpdateClient)
        {
            throw new NotImplementedException();
        }
        public void UpdateNutritionistClient(UpdateNutritionistClientInputModel UpdateClient)
        {
            throw new NotImplementedException();
        }
        public void UpdateClient(UpdateClientInputModel UpdateClient)
        {
            throw new NotImplementedException();
        }
    }
}
