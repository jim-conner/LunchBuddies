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

        public static string RandomRestaurant()
        {
            var random = new Random(); //get random value first

            // Jesse's version
            var enumValues = Enum.GetValues(typeof(RestaurantList)); //get [] of enums values
            var randomIndex = random.Next(enumValues.Length); //get random index based on length of enum array
            var restaurantName = (RestaurantList)enumValues.GetValue(randomIndex);
            return restaurantName.ToString();
        }

        public Restaurant()
        {
            var random = new Random(); //get random value first

            // nathan's in-class 
            //var RestaurantsList = Enum.GetValues<RestaurantList>();
            //int index = random.Next(RestaurantsList.Length);
            //RestaurantName = RestaurantsList[index].ToString();

            var RestaurantsList = Enum.GetValues(typeof(RestaurantList))
                .Cast<RestaurantList>().ToList();
            int index = random.Next(RestaurantsList.Count);
            RestaurantName = RestaurantsList[index].ToString();
          } 
    }
}
