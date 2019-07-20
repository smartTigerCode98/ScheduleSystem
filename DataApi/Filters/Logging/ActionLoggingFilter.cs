using System;
using Microsoft.AspNetCore.Mvc.Filters;
using Serilog;

namespace ScheduleSystem.DataApi.Filters.Logging
{
	internal sealed class ActionLoggingFilter : IActionFilter
	{
		private readonly ILogger            _logger;
		private          ActionLoggingModel _loggingModel;

		public ActionLoggingFilter(ILogger logger)
		{
			_logger = logger;
		}

		public void OnActionExecuting(ActionExecutingContext context)
		{
			_loggingModel = new ActionLoggingModel
			{
				RequestId      = context.ActionDescriptor.Id,
				Url            = context.HttpContext.Request.Path,
				ControllerName = context.RouteData.Values["controller"] as string,
				ActionName     = context.RouteData.Values["action"] as string,
				StartTime      = DateTime.UtcNow
			};

			_logger.Information("Request handling started. {0}", _loggingModel);
		}

		public void OnActionExecuted(ActionExecutedContext context)
		{
			_loggingModel.EndTime = DateTime.Now;

			_logger.Information("Request handling completed. {0} [{1}, {2} ms]", _loggingModel,
								context.HttpContext.Response.StatusCode, _loggingModel.TotalTime.Milliseconds);
		}
	}
}