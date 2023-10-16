using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IEmployeeRepository
    {
        void CreateEmployeeForCompany(Guid companyId, Employee employee);

        void DeleteEmployee(Employee employee);

        Task<IEnumerable<Employee>> GetEmployeesAsync(Guid companyId, bool trackChanges);

        Task<Employee> GetEmployeeAsync(Guid companyId, Guid id, bool trackChanges);

    }
}
