using Microsoft.EntityFrameworkCore;
using WebApplication1.DataBase;
using WebApplication1.NewFolder4;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddDbContext<EmployeesDataBase>();
builder.Services.AddDbContext<EmployeesDataBase>(options => options.UseSqlServer
("Server=DESKTOP-KQM4QPG;Database=Employees;Trusted_Connection=True"));
//builder.Services.AddDbContext<EmployeesDataBase>(options => options.UseSqlServer("***"));
builder.Services.AddSingleton<IProductRepocs, ProductRepocs>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
