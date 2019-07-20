using ScheduleSytem.Shared.Base;

namespace ScheduleSytem.Shared.Exceptions
{
	public class InvalidArgumentException : ScheduleSystemApplicationExceptionBase
	{
		private const string ErrorMessage = "Invalid argument supplied";
		
		public string Name { get; }
		public object Value { get; }

		public InvalidArgumentException(string name, object value, string message = ErrorMessage) : base(message)
		{
			Name = name;
			Value = value;
		}
	}
}