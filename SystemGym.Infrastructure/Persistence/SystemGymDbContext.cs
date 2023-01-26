﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemGym.Domain.Entities.v1.Client;
using SystemGym.Domain.Entities.v1.Employee;
using SystemGym.Domain.Enum.v1;

namespace SystemGym.Infrastructure.Persistence
{
    public class SystemGymDbContext
    {
        public SystemGymDbContext()
        {
            Employee = new List<Employee>
            {
                new Employee("Sidinei", "1234567", "(16) 99999-9999" , "sidinei@sidinei.com.br",AcademicEducationEnum.UniversiryCompleted,PositionEnum.Teacher, 1500 ),
                new Employee("Carlos", "987654321", "(16) 888888-8888" , "Carlos@marlos.com.br",AcademicEducationEnum.Doctor,PositionEnum.Coordinator, 3000),
                new Employee("Matheus", "192837465", "(16) 777777-7777" , "Matheus@matheus.com.br",AcademicEducationEnum.UniversiryCompleted,PositionEnum.Teacher, 2000)
            };

            Client = new List<Client>
            {
                new Client("Jhow", 22, "(11) 55555-5555","51.123.123-21"),
                new Client("Xico", 20, "(11) 44444-4444","52.456.321-22"),
                new Client("Jhow", 22, "(11) 33333-3333","53.789.213-23"),
            };
        }
        public List<Employee> Employee { get; set; }
        public List<Client> Client { get; set; }
    }
}