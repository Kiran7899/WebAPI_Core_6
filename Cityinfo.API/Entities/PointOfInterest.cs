using System.ComponentModel.DataAnnotations.Schema;

namespace Cityinfo.API.Entities
{
    public class PointOfInterest
    {
        public int id { get; set; }
        public string? Name { get; set; }

        [ForeignKey("CityId")]
        public City? City { get; set; }  

        public int CityId { get; set; }

        public PointOfInterest(string name)
        {
            Name = name;
        }
    }
}