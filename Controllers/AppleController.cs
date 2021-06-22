using Microsoft.AspNetCore.Mvc;

namespace routing_sample.Controllers
{
    public class AppleController : ControllerBase
    {
        [HttpGet("apples")]
        public void Get()
        {
        }
    }
}