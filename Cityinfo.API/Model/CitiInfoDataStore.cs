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
                    Description = "Capital of Tamilnadu" 
                },
                new CityInfoDto()
                {
                    Id = 2,
                    Name = "Bengaluru",
                    Description = "Capital of Karnataka"
                }
            };

        }
    }
}
