using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemGym.Application.InputModels.v1.Employee;
using SystemGym.Application.Services.Interfaces;

namespace SystemGym.Application.Services.Implementations
{
    public class EmployeeService : IEmployeeService
    {
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
