using System;
using SystemGym.Domain.Entities.v1.Client;

namespace SystemGym.Application.ViewModels.v1.Client
{
    public class ClientDetailsViewModels
    {
        public ClientDetailsViewModels(string name, 
                                      int age, 
                                      string phone, 
                                      string document, 
                                      string email, 
                                      bool active, 
                                      DateTime registrationDate)
        {
            Name = name;
            Age = age;
            Phone = phone;
            Document = document;
            Email = email;
            Active = active;
            RegistrationDate = registrationDate;
        }

        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Phone { get; private set; }
        public string Document { get; private set; }
        public string Email { get; private set; }
        public bool Active { get; private set; }
        public DateTime RegistrationDate { get; private set; }
    }
}
