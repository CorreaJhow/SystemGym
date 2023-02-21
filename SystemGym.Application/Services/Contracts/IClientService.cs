using System.Collections.Generic;
using SystemGym.Application.InputModels.v1.Client;
using SystemGym.Application.ViewModels.v1.Client;

namespace SystemGym.Application.Services.Contracts
{
    public interface IClientService
    {
        public int RegisterClient(NewClientInputModel newClient);

        public void DeleteClient(DeleteClientInputModel deleteClient);

        public List<ClientViewModel> GetAll();

        public ClientDetailsViewModels GetByDocument(string document);

        public void UpdateClient(string document, UpdateClientInputModel updateClient);

    }
}
