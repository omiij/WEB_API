using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        [Route("Employee")]
        public IActionResult Index()
        {
            Employee employee = new(){ id = 1, Name = "Onkar" };
            return employee;

        
    }
}
