using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using SystemGym.Domain.Enum.v1;

namespace SystemGym.Domain.Entities.v1.Employee
{
    public class Employee : BaseEntity
    {
        public Employee(string name, string document, string phone, string email, AcademicEducationEnum academicEducation, PositionEnum position, decimal salary)
        {
            Name = name;
            Document = document;
            Phone = phone;
            Email = email;
            AcademicEducation = academicEducation;
            Position = position;
            Salary = salary;

            Active = true;
            HiringDate = DateTime.Now;
            //Benefits.Ticket = true;
            //Benefits.GymFree = true;
            //Benefits.HealthInsurance = true;
        }

        public string Name { get; set; }
        public string Document { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public AcademicEducationEnum AcademicEducation { get; private set; }
        public PositionEnum Position { get; set; }
        public decimal Salary { get; set; } 
        public bool Active { get; set; }
        public DateTime HiringDate { get; set; }
        public EmployeeBenefits Benefits { get; set; }
    }
}
