namespace Cityinfo.API.Model
{
    public class CitiInfoDataStore
    {
        public List<CityInfoDto> Cities { get; set; }

        public static CitiInfoDataStore current { get; } = new CitiInfoDataStore();
        public  CitiInfoDataStore()
        {
            Cities = new List<CityInfoDto>() {

                new CityInfoDto()
                {
                    Id = 1,
                    Name = "Chennai",
                    Description = "Capital of Tamilnadu",

                    pointOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto() { 
                            Id = 1,
                            Name="Phoenix Mall",
                            Description="Shopping mall"
                        },
                        new PointOfInterestDto() { 
                            Id = 2,
                            Name="Marina Beach",
                            Description="Beach"
                        }
                    }
                },
                new CityInfoDto()
                {
                    Id = 2,
                    Name = "Bengaluru",
                    Description = "Capital of Karnataka",

                    pointOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto() {
                            Id = 1,
                            Name="IT Park",
                            Description="To work"
                        },
                        new PointOfInterestDto() {
                            Id = 2,
                            Name="IPL",
                            Description="Cricket"
                        }
                    }
                }
            };

        }
    }
}
