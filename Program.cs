using System;
using System.Collections.Generic;

namespace Lists_Jackson_Lydia

{
    internal class Program
    {
        static void Main(string[] args)
        {
            // a list containing names of games
            List<string> games = new List<string>
            {
                "Genshin Impact",
                "Borderlands 2",
                "Cult of the Lamb",
                "Animal Crossing",
                "The Last Campfire",
                "The Stanley Parable",
            };

            // array listing more games
            string[] otherGames = new string[]
            {
                "Gone Home",
                "Pico Park",
                "Badland,",
                "Sims 4",
                "Garfield Kart Racing",
            };

            foreach(string game in games) 
            { 
                Console.WriteLine(game);
            }

            Console.WriteLine($"Game in List: {games.Count}");

            games.AddRange(otherGames);

            Console.WriteLine($"Game in List: {games.Count}");

            if (games.Contains("Halo"))
            {
                Console.WriteLine("MASTER CHIEF is in the house!");
            }
            else
            {
                games.Add("Halo");
            }

            int myInt = 6;

            if(myInt < games.Count) 
            {
                games.RemoveAt(myInt);
            }
            else
            {
                Console.WriteLine("Game Not Found.");
            }

            Console.WriteLine("All Games in The List:");

            foreach (string game in games)
            {
                Console.WriteLine(game);
            }

            games.Sort();

            Console.WriteLine("Sorted Games List:");

            foreach (string game in games)
            {
                Console.WriteLine(game);
            }

            string[] newList = new string[games.Count];

            games.CopyTo(newList);

            games.Clear();

            Console.WriteLine("New List:");
            foreach(string game in newList)
            {
                Console.WriteLine(game);
            }

        }
    }
}