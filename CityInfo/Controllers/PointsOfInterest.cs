using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PointsOfInterestController : ControllerBase
    {
        [HttpGet("api/cities/pointsofinterest")]
        public ActionResult GetPointOfInterest(int cityid)
        {
            var currentCity = CitiesDataStore.Current.Cities.FirstOrDefault(city => city.Id == cityid);
            if(currentCity == null)
            {
                return NotFound();
            }

            return Ok(currentCity.PointsOfInterest);
        }
    }
}
