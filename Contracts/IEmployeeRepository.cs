﻿using Entities.Domain.Models;

namespace Contracts
{
    namespace Contracts
    {
        public interface IEmployeeRepository
        {
            IEnumerable<Employee> GetEmployees(Guid companyId, bool trackChanges);
            Employee GetEmployee(Guid companyId, Guid id, bool trackChanges);
        }

    }

}
