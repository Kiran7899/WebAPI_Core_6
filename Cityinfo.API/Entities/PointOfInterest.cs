using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cityinfo.API.Entities
{
    public class PointOfInterest
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string? Name { get; set; }

        [ForeignKey("CityId")]
        public City? City { get; set; }  


        public int CityId { get; set; }

        [MaxLength]
        public string Description { get; set; }

        public PointOfInterest(string name)
        {
            Name = name;
        }
    }
}