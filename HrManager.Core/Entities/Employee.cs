using System;
using HrManager.Core.Enums;
using HrManager.Core.Exceptions;

namespace HrManager.Core.Entities
{
	public class Employee
	{
        public Employee(string fullName, string document, DateTime birthDate, RoleLevel roleLevel, string role)
        {
            Id = Guid.NewGuid();
            FullName = fullName;
            Document = document;
            BirthDate = birthDate;
            RoleLevel = roleLevel;
            Role = role;
        }

        public Guid Id { get; private set; }
        public string FullName { get; private set; }
        public string Document { get; private set; }
        public DateTime BirthDate { get; private set; }
        public RoleLevel RoleLevel { get; private set; }
        public string Role { get; private set; }
    }
}

