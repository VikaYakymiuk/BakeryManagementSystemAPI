using BakeryManagementSystemBLL.Contracts;
using BakeryManagementSystemBLL.Services;
using BakeryManagementSystemDAL.Context;
using BakeryManagementSystemDAL.Contracts.Patterns;
using BakeryManagementSystemDAL.Repositories.Patterns;
using Microsoft.EntityFrameworkCore;

namespace BakeryManagementSystemAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddAutoMapper(typeof(Program).Assembly);

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<BakeryManagementSystemContext>(configurations =>
            {
                configurations.UseSqlServer(builder.Configuration.GetConnectionString("sqlConnection"),
                    migrations => migrations.MigrationsAssembly("BakeryManagementSystemAPI"));
            });

            builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
            builder.Services.AddScoped<IDistriburorsService, DistriburorsService>();
            builder.Services.AddScoped<ICustomersService, CustomersService>();
            builder.Services.AddScoped<IProductsService, ProductsService>();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}