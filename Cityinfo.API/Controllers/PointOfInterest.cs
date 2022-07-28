using Cityinfo.API.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cityinfo.API.Controllers
{
    [Route("api/cities/{cityid}/PointsOfInterest")]
    [ApiController]
    public class PointOfInterestController : ControllerBase
    {

        private readonly ILogger<PointOfInterestController> _logger;    
        public PointOfInterestController(ILogger<PointOfInterestController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public ActionResult<IEnumerable<PointOfInterestDto>> GetPointOfInterest(int cityid)
        {
            var city = CitiInfoDataStore.current.Cities.FirstOrDefault(c => c.Id == cityid);
            if (city == null)
            {
                _logger.LogInformation("Not found");
                return NotFound();
            }

            return Ok(city.pointOfInterest);
        }
    }
}
