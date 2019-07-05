
using Microsoft.AspNetCore.Mvc;
using ScheduleSystem.ScheduleAPI.Controllers.ModelView;
using Controller = ScheduleSystem.ScheduleAPI.Abstract.Controller;

namespace ScheduleSystem.ScheduleAPI.Controllers
{
    [ApiController]
    [Route("schedule")]
    public class ScheduleController : Controller
    {
        [HttpGet]
        public IActionResult ShowAll()
        {
            return Ok();
        }

        [HttpGet]
        [Route("teacher/{name}")]
        public IActionResult FindByTeacherName([FromRoute]string name)
        {
            return Ok(name);
        }

        [HttpGet]
        [Route("group/{name}")]
        public IActionResult FindByGroupName([FromRoute] string name)
        {
            return Ok(name);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult FindById([FromRoute] int id)
        {
            return Ok(id);
        }

        [HttpPost]
        public IActionResult Add(ScheduleModel scheduleModel)
        {
            return Ok(scheduleModel);
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Update([FromRoute] int id)
        {
            return Ok(id);
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            return Ok(id);
        }
    }
}