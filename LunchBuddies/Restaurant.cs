using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchBuddies
{
    class Restaurant
    {
        public string RestaurantName { get; set; }
        private RestaurantList RestaurantList { get; set; }
        //private List<string> RestaurantsList { get; set; }


        public Restaurant()
        {
            var random = new Random();
            List<RestaurantList> RestaurantsList = Enum.GetValues(typeof(RestaurantList))
                .Cast<RestaurantList>().ToList();
            int index = random.Next(RestaurantsList.Count);
            RestaurantName = RestaurantsList[index].ToString();
          } 
    }
}
