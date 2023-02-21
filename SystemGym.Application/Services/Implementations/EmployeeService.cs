using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Reflection.Metadata;
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
        public int DeleteEmployee(DeleteEmployeeInputModel deleteEmployeeInputModel)
        {
            var employees = _dbContext.Employee;

            foreach (var employee in employees)
            {
                if (employee.Document.Equals(deleteEmployeeInputModel.Document))
                {
                    employees.Remove(employee);
                    return 1;
                }
            }
            return 0;
        }

        public List<ViewEmployeeModel> GetAll()
        {
            var employess = _dbContext.Employee;

            return employess.Select(e => new ViewEmployeeModel(e.Name, e.Position, e.HiringDate, e.Active, e.Document)).ToList();
        }

        public ViewEmployeeModel GetByDocument(string document)
        {
            var employee = _dbContext.Employee.Where(e => e.Document.Equals(document))
                                    .Select(e => new ViewEmployeeModel(e.Name, e.Position, e.HiringDate, e.Active, e.Document)).ToList();

            if (employee is null)
                return null;

            return employee.FirstOrDefault();
        }

        public int RegisterEmployee(RegisterEmployeeInputModel newEmployeeInputModel)
        {
            var employeeExist = _dbContext.Employee.Where(e => e.Document.Equals(newEmployeeInputModel.Document))
                                    .Select(e => new ViewEmployeeModel(e.Name, e.Position, e.HiringDate, e.Active, e.Document)).ToList();

            if (employeeExist.Count == 0)
            {
                _dbContext.Employee.Add(new Employee(newEmployeeInputModel.Name, newEmployeeInputModel.Document, newEmployeeInputModel.Phone,
                           newEmployeeInputModel.Email, newEmployeeInputModel.AcademicEducation, newEmployeeInputModel.Position,
                           newEmployeeInputModel.Salary));

                return 1;
            }
            else
            {
                return 0; //funcionario com esse cpf já registrado
            }
        }

        public int UpdateEmployee(string document, UpdateEmployeeInputModel updateEmployeeInputModel)
        {
            var employee = _dbContext.Employee.FirstOrDefault(e => e.Document.Equals(document));

            if (employee is null)
                return 0;

            _dbContext.Employee.Remove(employee);

            var updateEmployee = new Employee(updateEmployeeInputModel.Name, updateEmployeeInputModel.Document, updateEmployeeInputModel.Phone, updateEmployeeInputModel.Email,
                                                 updateEmployeeInputModel.AcademicEducation, updateEmployeeInputModel.Position, updateEmployeeInputModel.Salary);

            _dbContext.Employee.Add(updateEmployee);

            return 1;
        }
    }
}
