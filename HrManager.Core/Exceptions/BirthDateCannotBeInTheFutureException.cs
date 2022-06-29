using System;
namespace HrManager.Core.Exceptions
{
	public class BirthDateCannotBeInTheFutureException : Exception
	{
		public BirthDateCannotBeInTheFutureException() : base("Birth date cannot be in the future.")
		{
		}
	}
}

