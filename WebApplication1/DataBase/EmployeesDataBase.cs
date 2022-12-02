using Microsoft.EntityFrameworkCore;



namespace WebApplication1.DataBase

{
    public class EmployeesDataBase : DbContext
    {

        public EmployeesDataBase(DbContextOptions<EmployeesDataBase> options) : base(options) { }

        public DbSet<EmployeesDetails> Employees { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)


        {
            optionsBuilder.UseSqlServer("Server=.;Database=EmployeeDB;Integrated Security=True;");
            base.OnConfiguring(optionsBuilder);
        }


    }
}
