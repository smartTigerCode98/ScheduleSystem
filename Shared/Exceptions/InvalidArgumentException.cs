using System.Collections.Generic;
using ScheduleSytem.Shared.Base;

namespace ScheduleSytem.Shared.Exceptions
{
	public class InvalidArgumentException<TArgument> : ScheduleSystemApplicationExceptionBase
	{
		public const string ErrorMessage = "Invalid argument supplied";

		public InvalidArgumentException(string name, TArgument value, string message = ErrorMessage)
				: base(new KeyValuePair<string, TArgument>(name, value), message) { }
	}
}