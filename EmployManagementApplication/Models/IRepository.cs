using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployManagementApplication.Models
{
    public interface IRepository
    {
        Task<List<Employee>> GetAllEmployee();

        Task<int> SaveEmployee(Employee employee);

        Task<int> DeleteEmployee(int id);
    }
}
