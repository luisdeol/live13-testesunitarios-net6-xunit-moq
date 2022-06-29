using System;
using HrManager.Application.Models.InputModels;
using HrManager.Application.Models.ViewModels;

namespace HrManager.Application.Services
{
	public interface IEmployeeService
	{
		AddEmployeeViewModel Add(AddEmployeeInputModel model);
	}
}

