using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;

namespace Using_KendoUI.ApiControllers
{
    public class CityController : ApiController
    {
        [HttpGet]
        public IEnumerable<City> Cities()
        {
            var id = Request.RequestUri.ParseQueryString()["id"] == null
                ? 0
                : Convert.ToInt32(Request.RequestUri.ParseQueryString()["id"]);

            if (id == 0)
                return _cities.Select(c => new City
                {
                    Id = c.Id,
                    Name = c.Name,
                    HasChildren = c.HasChildren
                });
            var value = _cities.First(c => c.Id == id).Cities.Select(c => new City
            {
                Id = c.Id,
                Name = c.Name,
                HasChildren = c.HasChildren
            });
            return value;
        }

        private readonly IEnumerable<City> _cities;

        public CityController()
        {
            _cities = new List<City>
            {
                new City {Id = 1, Name = "Tehran", HasChildren = true , Cities = new List<City>
                {
                   new City {Id = 11, Name = "Tajrish", HasChildren = false},
                   new City {Id = 12, Name = "Lavasan", HasChildren = false},
                   new City {Id = 13, Name = "Rey", HasChildren = false},
                }},
                new City {Id = 2, Name = "Esfahan", HasChildren = true},
                new City {Id = 3, Name = "Tabriz", HasChildren = true},
                new City {Id = 4, Name = "Shiraz", HasChildren = true}
            };
        }
    }

    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool HasChildren { get; set; }
        public IEnumerable<City> Cities { get; set; }
    }
}