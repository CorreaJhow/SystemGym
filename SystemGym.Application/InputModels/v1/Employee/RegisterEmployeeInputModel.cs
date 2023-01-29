using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemGym.Domain.Enum.v1;

namespace SystemGym.Application.InputModels.v1.Employee
{
    public class RegisterEmployeeInputModel
    {
        public string Name { get; set; }
        public string Document { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public AcademicEducationEnum AcademicEducation { get; private set; }
        public PositionEnum Position { get; set; }
        public decimal Salary { get; set; }
    }
}
