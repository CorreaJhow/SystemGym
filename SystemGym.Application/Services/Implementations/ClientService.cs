using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemGym.Application.InputModels.v1.Client;
using SystemGym.Application.Services.Interfaces;

namespace SystemGym.Application.Services.Implementations
{
    public class ClientService : IClientService
    {
        public int RegisterClient(NewClientInputModel newClient)
        {
            throw new NotImplementedException();
        }

        public void DeleteClient(DeleteClientInputModel deleteClient)
        {
            throw new NotImplementedException();
        }

        public List<ClientViewModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public ClientViewModel GetByDocument(string document)
        {
            throw new NotImplementedException();
        }

        public void UpdateClient(UpdateClientInputModel UpdateClient)
        {
            throw new NotImplementedException();
        }
    }
}
