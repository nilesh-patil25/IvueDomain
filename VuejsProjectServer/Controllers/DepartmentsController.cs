using IvueDomain.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VuejsProjectServer.Models;

namespace VuejsProjectServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentRepository departmentRepository;

        public DepartmentsController(IDepartmentRepository departmentRepository)
        {
            this.departmentRepository = departmentRepository;
        }
        [HttpGet]
        public async Task<ActionResult> GetDepartments()
        {
            var departments = await departmentRepository.GetDepartments();
            return Ok(departments);
        }


        [HttpGet("{id:int}")]
        public async Task<ActionResult<Department>> GetDepartment(int id)
        {
            var result = await departmentRepository.GetDepartment(id);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

    }
}
