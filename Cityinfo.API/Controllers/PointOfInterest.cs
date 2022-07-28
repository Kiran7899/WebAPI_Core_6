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

        [HttpGet("{pid}")]
        public ActionResult<PointOfInterestDto> GetPoI(int cityid,int pid)
        {
            var city = CitiInfoDataStore.current.Cities.FirstOrDefault(c => c.Id == cityid);
            if (city == null)
            {
                _logger.LogInformation("Not found");
                return NotFound();
            }
            var poi = city.pointOfInterest.FirstOrDefault(p => p.Id == pid);
            return Ok(poi);
        }

        [HttpGet]
        public ActionResult<IEnumerable<PointOfInterestDto>> GetPointOfInterest(int cityid)
        {
            try
            {
                //throw new Exception("Just for fun");
                var city = CitiInfoDataStore.current.Cities.FirstOrDefault(c => c.Id == cityid);
                if (city == null)
                {
                    _logger.LogInformation("Not found");
                    return NotFound();
                }

                return Ok(city.pointOfInterest);
            }
            catch (Exception ex)
            {
                _logger.LogCritical("Exception occured", ex);
                return StatusCode(500,"Server Error");
            }
        }
    }
}
