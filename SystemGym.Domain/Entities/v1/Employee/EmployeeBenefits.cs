using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemGym.Domain.Entities.v1.Employee
{
    public class EmployeeBenefits
    {
        public EmployeeBenefits(bool ticket, bool healthInsurance, bool gymFree)
        {
            Ticket = ticket;
            HealthInsurance = healthInsurance;
            GymFree = gymFree;
            HiringDate = DateTime.Now;
        }

        public bool Ticket { get; private set; }
        public bool HealthInsurance { get; private set; }
        public bool GymFree { get; private set; }
        public DateTime HiringDate { get; private set; }
    }
}
