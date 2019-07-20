using System;

namespace ScheduleSytem.Shared.Base
{
	public abstract class ScheduleSystemUserExceptionBase : Exception
	{
		protected ScheduleSystemUserExceptionBase() { }

		protected ScheduleSystemUserExceptionBase(string message) : base(message)
		{
		}
	}
}