using System;
using AutoFixture;
using HrManager.Application.Models.InputModels;
using HrManager.Application.Services;
using HrManager.Core.Entities;
using HrManager.Core.Exceptions;
using HrManager.Core.Repositories;
using Moq;
using Shouldly;
using Xunit;

namespace HrManager.UnitTests.Application.Services.EmployeeServiceTests
{
	public class EmployeeServiceAddTests
	{
		[Fact]
		public void ValidEmployee_AddIsCalled_ReturnValidEmployeeViewModel()
		{
			
		}

		[Fact]
		public void InvalidBirthDateForEmployee_AddIsCalled_ThrowAnInvalidBirthDateException()
        {
			
		}
	}
}

