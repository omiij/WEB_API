using WebApplication1.Modals;

namespace WebApplication1.Repository
{
    public interface IEmployeesRepo
    {
        Task<List<EmployeesModal>> GetAllEmployees();
    }
}