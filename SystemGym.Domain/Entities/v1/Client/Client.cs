using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemGym.Domain.Entities.v1.Client
{
    public class Client : BaseEntity
    {
        public Client(string name, int age, string phone, string document)
        {
            Name = name;
            Age = age;
            Phone = phone;
            Document = document;
            Active = true;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public string Document { get; set; }
        public bool Active { get; set; }
        public DateTime RegistrationDate { get; set; }
        public ClientBenefits Benefits { get; set; }
    }
}
