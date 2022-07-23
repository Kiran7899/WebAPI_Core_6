using CityInfo.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.Model
{
    public class CityDto //: IActionResult
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }


        public ICollection<PointOfInterestDto> PointsOfInterest { get; set; }
            = new List<PointOfInterestDto>();

        /*  public Task ExecuteResultAsync(ActionContext context)
          {
              throw new NotImplementedException();
          }

          public static explicit operator ActionResult(CityDto v)
          {
              return new JsonResult(v);// CityDto();
          }*/
    }

   
}
