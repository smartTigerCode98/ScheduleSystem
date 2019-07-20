using System;

namespace ScheduleSystem.DataApi.Filters.Logging
{
	internal sealed class ActionLoggingModel
	{
		public string   RequestId      { get; set; }
		public string   Url            { get; set; }
		public string   ControllerName { get; set; }
		public string   ActionName     { get; set; }
		public DateTime StartTime      { get; set; }
		public DateTime EndTime        { get; set; }
		public TimeSpan TotalTime      => EndTime.Subtract(StartTime);

		public override string ToString()
		{
			return $"[{RequestId}] | {Url} | {ControllerName}:{ActionName}";
		}
	}
}