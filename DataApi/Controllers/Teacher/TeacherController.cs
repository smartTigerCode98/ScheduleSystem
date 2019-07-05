using Microsoft.AspNetCore.Mvc;
using ScheduleSystem.DataApi.Base;
using ScheduleSystem.DataApi.Controllers.Teacher.ViewModels;

namespace ScheduleSystem.DataApi.Controllers.Teacher
{
	[Route("teachers")]
	public class TeacherController : ApiControllerBase
	{
		[HttpPost]
		[Route("add")]
		public IActionResult Add([FromBody] TeacherViewModel teacherViewModel)
		{
			return Ok(teacherViewModel);
		}
	}
}