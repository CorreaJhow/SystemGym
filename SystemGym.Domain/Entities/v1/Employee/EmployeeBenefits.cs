using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemGym.Domain.Entities.v1.Employee
{
    public class EmployeeBenefits : BaseEntity
    {
        public EmployeeBenefits(bool ticket, bool healthInsurance, bool gymFree)
        {
            Ticket = ticket;
            HealthInsurance = healthInsurance;
            GymFree = gymFree;
        }

        public bool Ticket { get; set; }
        public bool HealthInsurance { get; set; }
        public bool GymFree { get; set; }
    }
}
