using System;
using beerProject;

namespace beerProject
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            // starts by defining the main beer types that will be used by the app

            string[] beerTypes = new string[8] { "amber", "blonde", "fruit", "cream", "pale", "stout", "strong", "wheat" };

            // Title - displayed at top of app

            var appName = "Discover Indiana Beers";
            var appAuthor = "Simon Gamboa";

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("{0}: created by {1}\n", appName, appAuthor);
            Console.ForegroundColor = ConsoleColor.White;


            // Starts with user choosing from list of beer options

            Console.WriteLine("This app is designed to help you discover new local beers in the Indy area.\nPress Enter to continue.");
            Console.ReadLine();

            Console.WriteLine("Which type of beer do you prefer? \nChoose from the following or type \'Not sure\'\n");

            foreach (var beer in beerTypes)
            {
                Console.WriteLine(beer);
            }


            GetRecommend();

        }

        // This is the static method that is invoked when the app runs

        public static void GetRecommend()
        {
            // These strings store the various beer types as well as the suggestions for each category

            string[] beerTypes = new string[8] { "amber", "blonde", "fruit", "cream", "pale", "stout", "strong", "wheat" };

            string[] amberBeers = new string[5] { "The Ram - Buttface Amber Ale", "MashCraft - Red", "TwoDEEP - Brickhouse", "Fountain Square Brewery - Preacher's Daughter", "Round Town - Stray Monk", };
            string[] blondeBeers = new string[5] { "MashCraft: Gold", "Flat12 - Sour Peach Blonde", "Shale Creek - Tipsy Blonde", "Four Day Ray - Blood Orange Blonde", "Taxman - Golden Parachute", };
            string[] fruitBeers = new string[5] { "Misbeehavin Meads - Black Raspberry Cider", "Sun King - Grapefruit Jungle", "Rock Bottom - Tropical Swirl", "Taxman - Taxmango", "Indiana City Beer - Death by Pumpkin", };
            string[] creamBeers = new string[5] { "Flat12 - Pace Lap Cream Ale", "Shale Creek - Creekside Cream Ale", "Twodeep - Knightstick", "Sun King - Sunlight", "Little Kings Brewing - Little Kings Cream Ale (Cincinnati, OH)", };
            string[] paleBeers = new string[5] { "Three Floyds - Zombie Dust", "Sun King - Pachanga", "Round Town - Happy Face", "Shale Creek - Shale Pale Ale", "Four Day Ray - Track Jumper IPA", };
            string[] stoutBeers = new string[5] { "Brew Link Brewing - Ivory White Stout", "Indiana City Brewer - Shadow Boxer", "Scarlet Lane - Dorian Outmeal Stout", "Black Acre - One 10 Coffee Stout", "Flat12 - Pinko Russian Imperial Stout", };
            string[] strongBeers = new string[5] { "Three Floyds - Chemtrailmix", "Four Fathers - Wheelhouse", "Flat12 - Wing Team", "Shale Creek - Legend of Nessie", "Four Day Ray - Monk Tears", };
            string[] wheatBeers = new string[5] { "Three Floyds - Gumballhead", "Rock Bottom - Liquid Sun", "Round Town - Southside", "Upland - Upland Wheat", "Barley Island - Flat Top Wheat", };

            // asks for a user input

            string input = (Console.ReadLine().ToLower().Trim());

            Console.WriteLine("Here's a local suggestion for you:");

            // define random variable with 5 possible outcomes between 0-4

            Random r = new Random();
            int randomNumber = r.Next(0, 4);

            // takes randomNumber variable and pulls corresponding beer from the correct string

            Console.ForegroundColor = ConsoleColor.Red;

            if (input == beerTypes[0])
            {

                Console.WriteLine(amberBeers[randomNumber]);

            }
            else if (input == beerTypes[1])
            {

                Console.WriteLine(blondeBeers[randomNumber]);

            }
     
            else if (input == beerTypes[2])
            {

                Console.WriteLine(fruitBeers[randomNumber]);

            }
            else if (input == beerTypes[3])
            {

                Console.WriteLine(creamBeers[randomNumber]);

            }
            else if (input == beerTypes[4])
            {

                Console.WriteLine(paleBeers[randomNumber]);

            }
            else if (input == beerTypes[5])
            {

                Console.WriteLine(stoutBeers[randomNumber]);

            }
            else if (input == beerTypes[6])
            {

                Console.WriteLine(strongBeers[randomNumber]);

            }
            else if (input == beerTypes[7])
            {

                Console.WriteLine(wheatBeers[randomNumber]);

            }
            else if (input == "not sure")
            {

                Console.WriteLine("That's okay! Here's our recommendation this month: " + paleBeers[5]);

            }
            else
            {
                Console.WriteLine("We didn't recognize that. Try typing a selection from the list.");
                Console.ForegroundColor = ConsoleColor.White;
                GetRecommend();

            }

            // reset color after suggestion is made

            Console.ForegroundColor = ConsoleColor.White;

            // calls on playagain method to see if user wants another suggestion

            PlayAgain();

        }


        public static void PlayAgain()
        {

            // after the result is returned, this method is invoked which asks if the user would like to run it again

            Console.WriteLine("Would you like another suggestion? Yes/no");
            string answer = (Console.ReadLine().ToLower().Trim());

            if (answer == "yes")
            {
                Console.WriteLine("Which type of beer do you prefer?");
                GetRecommend();
            }
            else if (answer == "no")
            {
                Console.WriteLine("Enjoy!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Didn't recognize that.");
                Console.ForegroundColor = ConsoleColor.White;
                PlayAgain();
            }

        }
    }
}