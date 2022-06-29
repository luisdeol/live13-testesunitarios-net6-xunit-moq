using System;
using HrManager.Core.Entities;

namespace HrManager.Application.Models.ViewModels
{
	public class AddEmployeeViewModel
	{
        public AddEmployeeViewModel(string fullName, string document, DateTime birthDate, int roleLevel, string role)
        {
            FullName = fullName;
            Document = document;
            BirthDate = birthDate;
            RoleLevel = roleLevel;
            Role = role;
        }

        public string FullName { get; private set; }
        public string Document { get; private set; }
        public DateTime BirthDate { get; private set; }
        public int RoleLevel { get; private set; }
        public string Role { get; private set; }

        public static AddEmployeeViewModel FromEntity(Employee employee)
            => new(employee.FullName, employee.Document, employee.BirthDate, (int)employee.RoleLevel, employee.Role);
    }
}

