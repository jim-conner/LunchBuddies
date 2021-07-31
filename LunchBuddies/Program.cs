using System;
using System.Collections.Generic;

namespace LunchBuddies
{
    class Program
    {
        static void Main(string[] args)

        {   //don't have to write it out
            //List<LunchBuddy> buddies = new List<LunchBuddy>();
            var buddies = new List<LunchBuddy>();
            var buddy1 = new LunchBuddy("Jimmy", "Conner");
            var buddy2 = new LunchBuddy("Tom", "Sawyer");
            var buddy3 = new LunchBuddy("Geddy", "Lee");

            buddies.Add(buddy1);
            buddies.Add(buddy2);
            buddies.Add(buddy3);

            buddy1.Eat();
            buddy1.Eat("Dumplings");
            buddy1.Eat(buddies);
            buddy1.Eat("his own fingers", buddies);



        }
    }
}
