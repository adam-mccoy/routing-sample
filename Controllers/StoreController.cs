using Microsoft.AspNetCore.Mvc;

namespace routing_sample.Controllers
{
    public class StoreController : ControllerBase
    {
        [HttpGet("{storeId:int}")]
        public void Get()
        {
        }

        [HttpGet("{storeId:int}/address")]
        public void GetAddress()
        {
        }

        [HttpGet("{storeId:int}/nested/thing")]
        public void GetNestedThing()
        {
        }

        [HttpGet("{storeId:int}/some/other/thing")]
        public void GetSomeOtherThing()
        {
        }
    }
}