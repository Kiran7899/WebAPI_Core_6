using CityInfo.Model;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.Controllers
{
    [ApiController]
    [Route("api/CityInfo")]
    public class CityInfoController : ControllerBase
    {
        [HttpGet]
        public ActionResult<CityDto> Cities()
        {
            return Ok(CitiesDataStore.Current.Cities);

        }

        ////[HttpGet("{id}")]
        //[HttpGet("id")]
        //public ActionResult City(int id)
        //{
        //    var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id);
        //    if (city == null)
        //        return NotFound();
        //    return (ActionResult)city;
        //}

        [HttpGet("{id}")]
        public ActionResult City(int id)
        {
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id);
            if (city == null)
                return NotFound();
            return Ok(city);
        }
    }
}
