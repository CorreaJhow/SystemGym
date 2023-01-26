using System.Collections.Generic;
using SystemGym.Application.InputModels.v1.Client;
using SystemGym.Application.ViewModels.v1.Client;

namespace SystemGym.Application.Services.Interfaces
{
    public interface IClientService
    {
        List<ClientViewModel> GetAll(); 
        ClientViewModel GetByDocument(string document);
        int RegisterClient(NewClientInputModel newClient);
        void UpdateClient(UpdateClientInputModel UpdateClient);
        void DeleteClient(DeleteClientInputModel deleteClient);
    }
}
