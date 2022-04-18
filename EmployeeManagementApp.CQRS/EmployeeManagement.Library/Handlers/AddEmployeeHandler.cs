
using EmployeeManagement.Library.Commands;
using EmployeeManagement.Library.Data;
using EmployeeManagement.Library.Data.Repositories;
using EmployeeManagement.Library.Models;
using MediatR;

namespace EmployeeManagement.Library.Handlers
{
    public class AddEmployeeHandler : IRequestHandler<AddEmployeeCommand, EmployeeModel>
    {
        private readonly IEmployeeRepository _dataAccess;

        public AddEmployeeHandler(IEmployeeRepository dataAccess)
        {
            _dataAccess = dataAccess;
        }
        public Task<EmployeeModel> Handle(AddEmployeeCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_dataAccess.AddEmployee(request.FirstName, request.LastName));
        }
    }
}
