using System.Collections.Generic;
using System.Linq;
using SystemGym.Application.InputModels.v1.Employee;
using SystemGym.Application.Services.Contracts;
using SystemGym.Application.ViewModels.v1.Employee;
using SystemGym.Domain.Entities.v1.Employee;
using SystemGym.Infrastructure.Persistence;

namespace SystemGym.Application.Services.Implementations
{
    public class EmployeeService : IEmployeeService
    {
        private readonly SystemGymDbContext _dbContext;
        public EmployeeService(SystemGymDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void DeleteEmployee(DeleteEmployeeInputModel deleteEmployeeInputModel)
        {
            var employees = _dbContext.Employee;

            foreach (var employee in employees)
            {
                if (employee.Document.Equals(deleteEmployeeInputModel.Document))
                {
                    employees.Remove(employee);
                }
            }
        }

        public List<ViewEmployeeModel> GetAll()
        {
            var employess = _dbContext.Employee;

            return employess.Select(e => new ViewEmployeeModel(e.Name, e.Position, e.HiringDate, e.Active)).ToList();
        }

        public ViewEmployeeModel GetByDocument(string document)
        {
            var employees = _dbContext.Employee;

            var employee = employees.Where(e => e.Document.Equals(document))
                                    .Select(e => new ViewEmployeeModel(e.Name, e.Position, e.HiringDate, e.Active)).ToList();

            if (employee is null)
                return null;

            return employee.FirstOrDefault();
        }

        public int RegisterEmployee(RegisterEmployeeInputModel newEmployeeInputModel)
        {
            var employeeExist = _dbContext.Employee.Select(e => e.Document.Equals(newEmployeeInputModel.Document));

            if (employeeExist != null)
                return 0; //funcionario com esse cpf já registrado
            else
            {
                var employeeRegistered = new Employee(newEmployeeInputModel.Name, newEmployeeInputModel.Document, newEmployeeInputModel.Phone,
                         newEmployeeInputModel.Email, newEmployeeInputModel.AcademicEducation, newEmployeeInputModel.Position,
                         newEmployeeInputModel.Salary);

                _dbContext.Employee.Add(employeeRegistered);

                return employeeRegistered.Id;
            }
        }

        public void UpdatePositionEmployee(UpdatePositionEmployeeInputModel updateEmployeeInputModel)
        {
            var employee = _dbContext.Employee.FirstOrDefault(e => e.Document.Equals(updateEmployeeInputModel.Document));

            if (employee != null)
                return;
            _dbContext.Employee.Remove(employee);

            employee.Position = updateEmployeeInputModel.Position;

            _dbContext.Employee.Add(employee);
        }
    }
}
