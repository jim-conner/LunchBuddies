using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchBuddies
{
    class LunchBuddy
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Restaurant RandoResto { get; set; }

        public LunchBuddy(string firstName, string lastName)

        {
            FirstName = firstName;
            LastName = lastName;
            RandoResto = new Restaurant();

        }
    
        public void Eat ()
        {
            Console.WriteLine($"{FirstName} {LastName} is hangin' at {RandoResto.RestaurantName}.");

        }
        public void Eat (string food)
        {
            Console.WriteLine($"{FirstName} {LastName} just ate {food} at the office.");
        }

        public void Eat(List<LunchBuddy> companions)
        {
            string sentence = $"{FirstName} {LastName} is hangin' at {RandoResto.RestaurantName} with ";

            var count = companions.Count;
            foreach (var companion in companions)
            {
                if (--count  > 0)
                {
                sentence += $"{companion.FirstName}, ";
                }
                else
                {
                    sentence += $"and {companion.FirstName}.";
                }
            }
            Console.WriteLine(sentence);
        }
        public void Eat(string food, List<LunchBuddy> companions)
        {
            string sentence = $"{FirstName} {LastName} is hangin' at {RandoResto.RestaurantName} with ";

            var count = companions.Count;
            foreach (var companion in companions)
            {
                if (--count > 0)
                {
                    sentence += $"{companion.FirstName}, ";
                }
                else
                {
                    sentence += $"and {companion.FirstName}.";
                }
            }
            Console.WriteLine($"Then {FirstName} {LastName} just starts eating {food}....");
        }
    }

    
}
