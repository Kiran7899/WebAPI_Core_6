using Cityinfo.API.Model;
using Microsoft.AspNetCore.Mvc;

namespace Cityinfo.API.Controllers
{
    [Route("api/cities")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<CityInfoDto> Cities()
        {

            return new JsonResult(CitiInfoDataStore.current.Cities);

        }

        [HttpGet("{id}")]
        public ActionResult<CityInfoDto> City(int id)
        {
            CityInfoDto cityInfoDto = CitiInfoDataStore.current.Cities.FirstOrDefault(c => c.Id == id);
            if (cityInfoDto == null)
                return NotFound();
            return Ok(cityInfoDto);

            //return new JsonResult(CitiInfoDataStore.current.Cities.Where(c => c.Id == id));
        }

        //public ActionResult City(int id)
        //{
        //    return new JsonResult(new List<object> { new { id = id, name =} })
        //}


    }
}
