namespace Cityinfo.API.Model
{
    public class CityInfoDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public int NoOfPointOfInterest
        {
            get {
                return pointOfInterest.Count;
            }
        }

        public ICollection<PointOfInterestDto> pointOfInterest { get; set; } = 
            new List<PointOfInterestDto>();
    }
}
