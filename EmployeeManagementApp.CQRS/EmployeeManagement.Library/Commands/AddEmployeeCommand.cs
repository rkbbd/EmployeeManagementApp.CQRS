using EmployeeManagement.Library.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Library.Commands
{
    public record AddEmployeeCommand(string FirstName, string LastName) : IRequest<EmployeeModel>;
}
