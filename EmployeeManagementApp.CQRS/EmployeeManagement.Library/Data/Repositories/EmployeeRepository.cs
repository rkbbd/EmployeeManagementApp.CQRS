

using EmployeeManagement.Library.Data;
using EmployeeManagement.Library.Data.Repositories;
using EmployeeManagement.Library.Data.Repositories.Base;
using EmployeeManagement.Library.Models;
using Microsoft.EntityFrameworkCore;

namespace R.Infrastructure.Repositories
{
    public class EmployeeRepository : Repository<EmployeeModel>, IEmployeeRepository
    {
        public EmployeeRepository(EmployeeContext employeeContext) : base(employeeContext) { }
        public async Task<IEnumerable<EmployeeModel>> GetPersonByName(string name)
        {
            return await _employeeContext.Employees.Where(m => m.FirstName == name).ToListAsync();
        }

        public List<EmployeeModel> GetEmployees()
        {
            return _employeeContext.Employees.ToList();
        }

        public EmployeeModel AddEmployee(string firstName, string lastName)
        {
            EmployeeModel newEmployee = new() { FirstName = firstName, LastName = lastName };
            _employeeContext.Employees.Add(newEmployee); // .Max(x => x.Id) + 1;
            _employeeContext.SaveChanges();
            return newEmployee;
        }
    }
}
