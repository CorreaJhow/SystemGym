using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemGym.Application.ViewModels.v1.Client
{
    public class ClientViewModel
    {
        public ClientViewModel(string name, int age, string phone, bool active)
        {
            Name = name;
            Age = age;
            Phone = phone;
            Active = active;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public bool Active { get; set; }
    }
}
