using System.Collections.Generic;
using SystemGym.Application.InputModels.v1.Employee;
using SystemGym.Application.ViewModels.v1.Employee;

namespace SystemGym.Application.Services.Interfaces
{
    public interface IEmployeeService
    {
        public void DeleteEmployee(DeleteEmployeeInputModel deleteEmployeeInputModel);
        public List<ViewEmployeeModel> GetAll();
        public ViewEmployeeModel GetByDocument(string document);
        public int RegisterEmployee(RegisterEmployeeInputModel newEmployeeInputModel);
        public void UpdatePositionEmployee(UpdatePositionEmployeeInputModel updateEmployeeInputModel);
    }
}
