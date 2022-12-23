using Microsoft.EntityFrameworkCore;

namespace G201210055_WebTeknolojileri.Models
{
    public class CarContext:DbContext
    {
        public DbSet<Car> Cars { get; set;}

        public CarContext() : base()
        {

        }

     /*   protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = (localdb)\mssqllocaldb; Database=Car;Trusted_Connection=True;");
        }*/
    }
}
