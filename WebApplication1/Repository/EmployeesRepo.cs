using WebApplication1.DataBase;
using WebApplication1.Modals;
using Microsoft.EntityFrameworkCore;
namespace WebApplication1.Repository
{
    public class EmployeesRepo : IEmployeesRepo
    {

        private readonly EmployeesDataBase _context;

        public EmployeesRepo(EmployeesDataBase context)
        {
            _context = context;
        }
        public async Task<List<EmployeesModal>> GetAllEmployees()
        {
            var records = await _context.Employees.Select(x => new EmployeesModal()
            {
                ID = x.ID,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Gender = x.Gender,
                Salery = x.Salery,
            }
            ).ToListAsync();

            return records;
        }

    }
}
