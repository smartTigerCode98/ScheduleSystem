using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using ScheduleSytem.Shared.Base;
using Serilog;

namespace ScheduleSystem.DataApi.Filters
{
	internal sealed class ExceptionHandlingFilter : IActionFilter
	{
		private readonly ILogger _logger;

		public ExceptionHandlingFilter(ILogger logger)
		{
			_logger = logger;
		}

		public void OnActionExecuting(ActionExecutingContext context) { }

		public void OnActionExecuted(ActionExecutedContext context)
		{
			if (context.Exception == null)
			{
				return;
			}

			switch (context.Exception)
			{
				case ScheduleSystemUserExceptionBase userException:
				{
					_logger.Warning(userException, "User exception occured");
					context.Result = new BadRequestResult();
					break;
				}

				case ScheduleSystemApplicationExceptionBase appException:
				{
					_logger.Error(appException, "App exception occured");
					context.Result = new StatusCodeResult(500);
					break;
				}

				case Exception exception:
				{
					_logger.Fatal(exception, "Unhandled exception occured");
					context.Result = new StatusCodeResult(500);
					break;
				}
			}

			context.ExceptionHandled = true;
		}
	}
}