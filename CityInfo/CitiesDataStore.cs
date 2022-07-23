using CityInfo.API.Models;
using CityInfo.Model;
using Nito.Collections;

namespace CityInfo
{
    public class CitiesDataStore
    {
        public  List<CityDto> Cities { get; set; }

        public static CitiesDataStore Current { get; } = new CitiesDataStore();        

        public CitiesDataStore()
        {
            Cities = new List<CityDto>
            {
                new CityDto() { Id = 1, Name = "Chennai", Description = "TamilNadu",
                    PointsOfInterest = new List<PointOfInterestDto>()
                     {
                         new PointOfInterestDto() {
                             Id = 1,
                             Name = "Central Park",
                             Description = "The most visited urban park in the United States." },
                          new PointOfInterestDto() {
                             Id = 2,
                             Name = "Empire State Building",
                             Description = "A 102-story skyscraper located in Midtown Manhattan." },
                     } },
                new CityDto() { Id = 2, Name = "Bangalore", Description = "Karnataka",
                    PointsOfInterest = new List<PointOfInterestDto>()
                     {
                         new PointOfInterestDto() {
                             Id = 3,
                             Name = "Cathedral of Our Lady",
                             Description = "A Gothic style cathedral, conceived by architects Jan and Pieter Appelmans." },
                          new PointOfInterestDto() {
                             Id = 4,
                             Name = "Antwerp Central Station",
                             Description = "The the finest example of railway architecture in Belgium." },
                     }},
                new CityDto() { Id = 3, Name = "Cochin", Description = "Kerala",
                    PointsOfInterest = new List<PointOfInterestDto>()
                     {
                         new PointOfInterestDto() {
                             Id = 5,
                             Name = "Eiffel Tower",
                             Description = "A wrought iron lattice tower on the Champ de Mars, named after engineer Gustave Eiffel." },
                          new PointOfInterestDto() {
                             Id = 6,
                             Name = "The Louvre",
                             Description = "The world's largest museum." },
                     } }
            };
            
        }
        
    }
}
