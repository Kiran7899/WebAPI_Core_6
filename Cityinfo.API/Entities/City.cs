using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cityinfo.API.Entities
{
    public class City
    {
        public City(string name)
        {
            Name = name;    
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } 

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }    
        
        [MaxLength(255)]
        public string? Description { get; set; }

        public ICollection<PointOfInterest> PointsOfInterests { get; set; } = new List<PointOfInterest>();
    }
}
