using System;

namespace ScheduleSytem.Shared.Base
{
	public abstract class ScheduleSystemUserExceptionBase : Exception
	{
		public object UnhandledData { get; }

		protected ScheduleSystemUserExceptionBase(object data, string message = null) : base(message)
		{
			UnhandledData = data;
		}
	}
}