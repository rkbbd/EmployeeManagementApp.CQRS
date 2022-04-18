using EmployeeManagement.Library.Data.Repositories.Base;
using EmployeeManagement.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Library.Data.Repositories
{
    public interface IEmployeeRepository : IRepository<EmployeeModel>
    {
        List<EmployeeModel> GetEmployees();
        EmployeeModel AddEmployee(string firstName, string lastName);
    }
}
