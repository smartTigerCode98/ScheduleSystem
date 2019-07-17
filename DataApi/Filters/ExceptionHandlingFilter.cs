using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using ScheduleSytem.Shared.Base;

namespace ScheduleSystem.DataApi.Filters
{
	internal sealed class ExceptionHandlingFilter : IActionFilter
	{
		public void OnActionExecuting(ActionExecutingContext context) { }

		public void OnActionExecuted(ActionExecutedContext context)
		{
			if (context.Exception == null)
			{
				return;
			}

			switch (context.Exception)
			{
				case ScheduleSystemUserExceptionBase appException:
				{
					context.Result = new BadRequestObjectResult(appException.UnhandledData);
					break;
				}

				case Exception exception:
				{
					context.Result = new JsonResult(new { Message = exception.Message });

					context.HttpContext.Response.StatusCode = 500;
					break;
				}
			}

			context.ExceptionHandled = true;
		}
	}
}