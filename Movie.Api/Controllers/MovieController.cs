using Microsoft.AspNetCore.Mvc;

namespace Movie.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            return Ok();
        }
    }
}