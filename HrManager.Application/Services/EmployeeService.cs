using System;
using HrManager.Application.Models.InputModels;
using HrManager.Application.Models.ViewModels;
using HrManager.Core.Repositories;
using HrManager.Infrastructure.Persistence;

namespace HrManager.Application.Services
{
    public class EmployeeService : IEmployeeService
	{
        private readonly HrManagerDbContext _context;

        public EmployeeService(HrManagerDbContext context)
        {
            _context = context;
        }

		public AddEmployeeViewModel Add(AddEmployeeInputModel model)
        {
            var employee = model.ToEntity();

            _context.Employees.Add(employee);

            _context.SaveChanges();

            return AddEmployeeViewModel.FromEntity(employee);
        }
    }
}

