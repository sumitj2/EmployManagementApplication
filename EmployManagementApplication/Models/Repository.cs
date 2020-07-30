using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace EmployManagementApplication.Models
{
    public class Repository : IRepository
    {
      


        private EmployeeContext dbcontext;



        public Repository(EmployeeContext context)
        {
            dbcontext = context;
        }

        public async Task<int> DeleteEmployee(int id)
        {
           var entity= dbcontext.Employee.Where(x => x.Id == id).FirstOrDefault();
            dbcontext.Remove(entity);
            return dbcontext.SaveChanges();
            
        }

        public async Task<List<Employee>> GetAllEmployee()
        {
            // return  dbcontext.Employee.ToList();
            return await Task.Run(() => {

                return dbcontext.Employee.ToList();
            });
        }

        public async Task<int> SaveEmployee(Employee employee)
        {

            //return await Task.Run(() => {

            //    dbcontext.Employee.Add(employee);
            //    return dbcontext.SaveChanges();
            //});

            dbcontext.Employee.Add(employee);
            return dbcontext.SaveChanges();
        }
    }

}
