using Microsoft.AspNetCore.Mvc;
using ScheduleSystem.DataApi.Controllers.ModelView;

namespace ScheduleSystem.DataApi.Controllers
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