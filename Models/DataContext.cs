using Microsoft.EntityFrameworkCore;

namespace ERP.Models
{
     /*
        this class will handles the connection to DB
        and helps to retrieve/store/update data

        If somethings changes on the models/tables, exec:
        - dotnet ef migrations add <someName>
        - dotnet ef database update
    */

    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        // specify the list of models (classes) that you want to become a table on the DB
        public DbSet<Car> Cars { get; set; }
    }
}