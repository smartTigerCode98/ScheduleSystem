using System;

namespace ScheduleSytem.Shared.Base
{
	public abstract class ScheduleSystemApplicationExceptionBase : Exception
	{
		protected ScheduleSystemApplicationExceptionBase() { }

		protected ScheduleSystemApplicationExceptionBase(string message) : base(message)
		{
		}
	}
}