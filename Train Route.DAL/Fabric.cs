using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Train_Route.DAL
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();

            // Вкажіть вашу строку підключення (наприклад, для LocalDB / SQL Server)
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TrainRouteDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;");

            // Якщо ви використовуєте іншу БД (наприклад, SQLite або PostgreSQL), замініть UseSqlServer на вашу, наприклад:
            // optionsBuilder.UseSqlite("Data Source=trainroute.db");

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}