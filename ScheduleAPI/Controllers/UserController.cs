using Microsoft.AspNetCore.Mvc;
using ScheduleSystem.ScheduleAPI.Controllers.ModelView;
using Controller = ScheduleSystem.ScheduleAPI.Abstract.Controller;

namespace ScheduleSystem.ScheduleAPI.Controllers
{
    [ApiController, Route("users")]
    public class UserController : Controller
    {
        [HttpPost]
        [Route("login")]
        public IActionResult SignIn([FromBody] UserModel userModel)
        {
            return Ok(userModel);
        }

        [HttpPost]
        [Route("registration")]
        public IActionResult SignUp([FromBody] UserModel userModel)
        {
            return Ok(userModel);
        }
    }
}