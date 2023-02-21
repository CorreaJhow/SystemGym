using Microsoft.AspNetCore.Mvc;
using SystemGym.Application.InputModels.v1.Employee;
using SystemGym.Application.Services.Contracts;

namespace SystemGym.Controllers.v1.Employee
{
    [Route("api/v1/Employees")]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var employees = _employeeService.GetAll();

            if (employees is null)
            {
                return NotFound("Error message: There are no registered employees");
                //LogDeError
            }

            return Ok(employees);
        }

        [HttpGet("{document}")]
        public IActionResult GetByDocument(string document)
        {
            var employee = _employeeService.GetByDocument(document);

            if (employee is null)
            {
                return NotFound("Error message: No employees found with this document");
                //LogsError            
            }

            return Ok(employee);
        }

        [HttpPost]
        public IActionResult RegisterEmployee([FromBody] RegisterEmployeeInputModel registerEmployee)
        {
            var id = _employeeService.RegisterEmployee(registerEmployee);

            if (id == 0)
            {
                return BadRequest("Error message: Employee with this document already registered");
                //LogError            
            }

            return Ok("Successfully registered customer");
        }

        [HttpPut]
        public IActionResult UpdateEmployee(string document, [FromBody] UpdateEmployeeInputModel updateEmployee)
        {
            var id = _employeeService.UpdateEmployee(document, updateEmployee);

            if (id == 0)
            {
                return NotFound("Error message: No employees found with this document");
                //logerror
            }
            
            return Ok("Successfully updated employee");
        }

        [HttpDelete]
        public IActionResult DeleteEmployeeByDocument([FromBody] DeleteEmployeeInputModel deleteEmploye)
        {
            var id = _employeeService.DeleteEmployee(deleteEmploye);
            
            if(id == 0)
            {
                return NotFound("Error message: No employees found with this document");
                //logError
            }
            return Ok("Employee removed successfully");
        }
    }
}
