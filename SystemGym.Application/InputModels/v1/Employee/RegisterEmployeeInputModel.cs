using SystemGym.Domain.Enum.v1;

namespace SystemGym.Application.InputModels.v1.Employee
{
    public class RegisterEmployeeInputModel
    {
        public RegisterEmployeeInputModel(string name,
                                          string document,
                                          string phone,
                                          string email,
                                          AcademicEducationEnum academicEducation,
                                          PositionEnum position,
                                          decimal salary)
        {
            Name = name;
            Document = document;
            Phone = phone;
            Email = email;
            AcademicEducation = academicEducation;
            Position = position;
            Salary = salary;
        }

        public string Name { get; set; }
        public string Document { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public AcademicEducationEnum AcademicEducation { get; set; }
        public PositionEnum Position { get; set; }
        public decimal Salary { get; set; }
    }
}
