using System.Collections.Generic;
using SystemGym.Application.InputModels.v1.Employee;
using SystemGym.Application.ViewModels.v1.Employee;

namespace SystemGym.Application.Services.Interfaces
{
    public interface IEmployeeService
    {
        List<ViewEmployeeModel> GetAll();
        ViewEmployeeModel GetByDocument(string document);
        int RegisterEmployee(RegisterEmployeeInputModel newEmployeeInputModel);
        void UpdateEmployee(UpdateEmployeeInputModel updateEmployeeInputModel);
        void DeleteEmployee(DeleteEmployeeInputModel deleteEmployeeInputModel);
    }
}
