using System;

namespace ScheduleSytem.Shared.Base
{
	public abstract class ScheduleSystemApplicationExceptionBase : Exception
	{
		public object ApplicationData { get; }

		protected ScheduleSystemApplicationExceptionBase(object data, string message = null) : base(message)
		{
			ApplicationData = data;
		}
	}
}