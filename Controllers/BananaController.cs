using Microsoft.AspNetCore.Mvc;

namespace routing_sample.Controllers
{
    public class BananaController : ControllerBase
    {
        [HttpGet("bananas")]
        public void Get()
        {
        }
    }
}