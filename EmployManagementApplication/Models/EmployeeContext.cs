using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployManagementApplication.Models
{
    public class EmployeeContext //: DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options)
            : base(options)
        {

        }
        public DbSet<Employee> Employee { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            ////string connstring = "Server=tcp:gbdockerdb.database.windows.net,1433;Initial Catalog=gaurav;Persist Security Info=False; User ID=gauravcbhandari;Password=gomzzy@951991";// GetConnectionString().GetAwaiter().GetResult();
            ////string connstring = "Server=db;Initial Catalog=Employee;Persist Security Info=False;User ID=dbadmin;Password='tester@12345';";// GetConnectionString().GetAwaiter().GetResult();

            ////optionsBuilder.UseSqlServer(connstring);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          //  modelBuilder.Entity<Employee>().HasData(
            //   new Employee { Id = 1, Name = "James A", Surname = "james", Address = "Badlapur" },
              // new Employee { Id = 2, Name = "Malcolm B", Surname = "jagtap", Address = "Airoli" }
                //);
        }

    }
}
