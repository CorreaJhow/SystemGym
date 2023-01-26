using System;
using System.Collections.Generic;
using SystemGym.Application.InputModels.v1.Employee;
using SystemGym.Application.Services.Interfaces;
using SystemGym.Application.ViewModels.v1.Employee;
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
            throw new NotImplementedException();
        }

        public List<ViewEmployeeModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public ViewEmployeeModel GetByDocument(string document)
        {
            throw new NotImplementedException();
        }

        public int RegisterEmployee(RegisterEmployeeInputModel newEmployeeInputModel)
        {
            throw new NotImplementedException();
        }

        public void UpdateEmployee(UpdateEmployeeInputModel updateEmployeeInputModel)
        {
            throw new NotImplementedException();
        }
    }
}
