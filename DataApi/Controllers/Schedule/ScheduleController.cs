using Microsoft.AspNetCore.Mvc;
using ScheduleSystem.DataApi.Base;
using ScheduleSystem.DataApi.Controllers.Schedule.ViewModels;

namespace ScheduleSystem.DataApi.Controllers.Schedule
{
    [Route("schedule")]
    public class ScheduleController : ApiControllerBase
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
        public IActionResult Add(ScheduleViewModel scheduleViewModel)
        {
            return Ok(scheduleViewModel);
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