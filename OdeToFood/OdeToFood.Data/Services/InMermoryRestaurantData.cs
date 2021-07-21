using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data.Services
{
    public class InMermoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;

        public InMermoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                // This stores our sample data in memory. This would never be done in prod but is usefull for getting quick test data.
                new Restaurant {Id = 1, Name = "Benny's Ramen Bar", Cuisine = CuisineType.Japanese },
                new Restaurant {Id = 2, Name = "Benny's Pho", Cuisine = CuisineType.Vietnamese },
                new Restaurant {Id = 3, Name = "Benny's Express", Cuisine = CuisineType.Chinese },
            };
        }

        public Restaurant Get(int id)
        {
            return restaurants.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r => r.Name);
        }
    }
}
