using Microsoft.AspNetCore.Mvc;
using ScheduleSystem.DataApi.Controllers.ModelView;

namespace ScheduleSystem.DataApi.Controllers
{
    [ApiController, Route("users")]
    public class UserControllerBase : Base.ControllerBase
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