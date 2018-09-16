using Microsoft.AspNetCore.Mvc;

namespace APIVersioningDemo.Controllers
{
    [ApiVersionNeutral]
    [Route("api/neutral")]
    [ApiController]
    public class NeutralController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            const string message = "This is neutral version controller";
            return new JsonResult(message);
        }
    }
}
