using Microsoft.AspNetCore.Mvc;
using ScheduleSystem.ScheduleAPI.Controllers.ModelView;

namespace ScheduleSystem.ScheduleAPI.Controllers
{
    [ApiController, Route("teachers")]
    public class TeacherController : Controller
    {
        [HttpPost]
        [Route("add")]
        public IActionResult Add([FromBody]TeacherModel teacherModel)
        {
            return Ok(teacherModel);
        }
    }
}