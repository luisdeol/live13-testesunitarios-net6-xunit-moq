using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HrManager.Core.Entities;
using HrManager.Core.Repositories;

namespace HrManager.Infrastructure.Persistence.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly HrManagerDbContext _context;

        public EmployeeRepository(HrManagerDbContext context)
        {
            _context = context;
        }

        public void Add(Employee employee)
        {
            _context.Employees.Add(employee);

            _context.SaveChanges();
        }
    }
}