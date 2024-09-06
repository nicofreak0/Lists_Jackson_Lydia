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

            //prints the list of names to console
            foreach(string game in games) 
            { 
                Console.WriteLine(game);
            }

            //prints the number of games in the games list
            Console.WriteLine($"\nGAMES IN LIST: {games.Count}");

            //adds the total number of games in other games and games lists 
            games.AddRange(otherGames);

            //prints the updated number to console
            Console.WriteLine($"\nGAMES IN LIST: {games.Count}");

            // checks if halo is in the games list. if its not it adds it
            if (games.Contains("Halo"))
            {
                Console.WriteLine("\nMASTER CHIEF IS IN THE HOUSE!");
            }
            else
            {
                games.Add("Halo");
            }

            //sets the value of 6 to an integer
            int myInt = 6;

            //if myInt is less than the count of games remove the game at that index 
            //otherwise print to console game was not found
            if (myInt < games.Count) 
            {
                games.RemoveAt(myInt);
            }
            else
            {
                Console.WriteLine("\nGAME NOT FOUND.");
            }

            // prints all the game names in the games list
            Console.WriteLine("\nALL GAMES IN THE LIST:");

            foreach (string game in games)
            {
                Console.WriteLine(game);
            }

            // sorts the games alphabetically and prints them to console
            games.Sort();

            Console.WriteLine("\nSORTED GAMES LIST:");

            foreach (string game in games)
            {
                Console.WriteLine(game);
            }

            // creates a new string array with the same length as the games list
            string[] newList = new string[games.Count];

            // copy the contents of the games list into the newList array
            games.CopyTo(newList);

            // clears all elements from the games list
            games.Clear();

            // print the contents of the newList array
            Console.WriteLine("\nNEW LIST:");
            foreach(string game in newList)
            {
                Console.WriteLine(game);
            }

        }
    }
}