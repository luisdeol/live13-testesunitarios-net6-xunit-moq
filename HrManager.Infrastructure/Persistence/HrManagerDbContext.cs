using System;
using HrManager.Core.Entities;

namespace HrManager.Infrastructure.Persistence
{
	public class HrManagerDbContext
	{
		public HrManagerDbContext()
		{
			Employees = new List<Employee>();
		}

		public List<Employee> Employees { get; set; }

		public void SaveChanges() { }
	}
}

