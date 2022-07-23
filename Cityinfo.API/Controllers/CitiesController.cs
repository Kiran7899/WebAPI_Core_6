using Microsoft.AspNetCore.Mvc;

namespace Cityinfo.API.Controllers
{
    [Route("api/cities")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        [HttpGet]
        public ActionResult Cities()
        {

            return new JsonResult(new List<object> { new { id = 1,name = "Chennai" } });
            
        }

        public ActionResult City(int id)
        {
            return new JsonResult(new List<object> { new { id = id,name =}})
        }

        
    }
}
