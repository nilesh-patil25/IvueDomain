using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VuejsProjectServer.Models;

namespace IvueDomain.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeRepository employeeRepository;

        public EmployeesController(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }
        [HttpGet]
        public async Task<ActionResult> GetEmployees()
        {
            var employees = await employeeRepository.GetEmployees();
            return Ok(employees);
        }


        [HttpGet("{id:int}")]
        public async Task<ActionResult<Employee>> GetEmployee(int id)
        {
            var result = await employeeRepository.GetEmployee(id);

            if (result == null)
            {
                return NotFound();
            }

            return result;
        }


        [HttpPost]
        public async Task<ActionResult<Employee>> CreateEmployee(Employee employee)
        {
            if (employee == null)
                return BadRequest("Invalid employee data.");

            var existingEmployee = await employeeRepository.GetEmployee(employee.EmployeeId);

            if (existingEmployee != null)
            {
                ModelState.AddModelError("ID", "Employee ID already in use");
                return BadRequest(ModelState);
            }

            var createdEmployee = await employeeRepository.AddEmployee(employee);

            return CreatedAtAction(nameof(GetEmployee),
                new { id = createdEmployee.EmployeeId }, createdEmployee);
        }


        [HttpPut("{id:int}")]
        public async Task<ActionResult<Employee>> UpdateEmployee(int id, Employee employee)
        {
            if (id != employee.EmployeeId)
                return BadRequest("Employee ID mismatch");

            var employeeToUpdate = await employeeRepository.GetEmployee(id);

            if (employeeToUpdate == null)
                return NotFound($"Employee with Id = {id} not found");

            var updatedEmployee = await employeeRepository.UpdateEmployee(employee);
            return Ok(updatedEmployee);
        }


        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteEmployee(int id)
        {
            var employeeToDelete = await employeeRepository.GetEmployee(id);

            if (employeeToDelete == null)
            {
                return NotFound($"Employee with Id = {id} not found");
            }

            await employeeRepository.DeleteEmployee(id);

            return Ok($"Employee with Id = {id} deleted");
        }

    }
}
