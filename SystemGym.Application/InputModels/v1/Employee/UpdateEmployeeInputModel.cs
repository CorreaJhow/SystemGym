using SystemGym.Domain.Enum.v1;

namespace SystemGym.Application.InputModels.v1.Employee
{
    public class UpdateEmployeeInputModel
    {
        public UpdateEmployeeInputModel(string name, 
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

        public string Name { get; private set; }
        public string Document { get; private set; }
        public string Phone { get; private set; }
        public string Email { get; private set; }
        public AcademicEducationEnum AcademicEducation { get; private set; }
        public PositionEnum Position { get; private set; }
        public decimal Salary { get; private set; }
    }
}
