﻿using System;
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
            RegistrationDate = DateTime.Now;
            Benefits.Nutritionist = true;
            Benefits.VIP = true;
        }

        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Phone { get; private set; }
        public string Document { get; private set; }
        public bool Active { get; private set; }
        public DateTime RegistrationDate { get; private set; }
        public ClientBenefits Benefits { get; private set; }
    }
}
