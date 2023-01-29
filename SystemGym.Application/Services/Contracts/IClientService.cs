using System.Collections.Generic;
using SystemGym.Application.InputModels.v1.Client;
using SystemGym.Application.ViewModels.v1.Client;
using SystemGym.Domain.Entities.v1.Client;

namespace SystemGym.Application.Services.Interfaces
{
    public interface IClientService
    {
        public int RegisterClient(NewClientInputModel newClient);

        public void DeleteClient(DeleteClientInputModel deleteClient);

        public List<ClientViewModel> GetAll();

        public ClientViewModel GetByDocument(string document);

        public void UpdateVIPClient(UpdateVIPClientInputModel updateClient);

        public void UpdateNutritionistClient(UpdateNutritionistClientInputModel updateClient);

        public void UpdateClient(UpdateClientInputModel updateClient);
        
    }
}
