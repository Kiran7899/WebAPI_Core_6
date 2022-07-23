using Cityinfo.API.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cityinfo.API.Controllers
{
    [Route("api/cities/{cityid}/PointsOfInterest")]
    [ApiController]
    public class PointOfInterestController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<PointOfInterestDto>> GetPointOfInterest(int cityid)
        {
            var city = CitiInfoDataStore.current.Cities.FirstOrDefault(c => c.Id == cityid);
            if(city == null)
                return NotFound();

            return Ok(city.pointOfInterest);
        }
    }
}
