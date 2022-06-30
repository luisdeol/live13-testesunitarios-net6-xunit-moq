using HrManager.Application.Models.InputModels;
using HrManager.Application.Models.ViewModels;
using HrManager.Core.Repositories;

namespace HrManager.Application.Services
{
    public class EmployeeService : IEmployeeService
	{
        private readonly IEmployeeRepository _repository;

        public EmployeeService(IEmployeeRepository repository)
        {
            _repository = repository;
        }

		public AddEmployeeViewModel Add(AddEmployeeInputModel model)
        {
            var employee = model.ToEntity();

            _repository.Add(employee);

            return AddEmployeeViewModel.FromEntity(employee);
        }
    }
}

