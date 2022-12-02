using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.DataBase;
using WebApplication1.Modals;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Repository;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeesRepo _employeeRepo;

        public EmployeeController(IEmployeesRepo employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAllEmployees()
        {
            var employees=await _employeeRepo.GetAllEmployees();

            return Ok(employees);

        }
    }
}
