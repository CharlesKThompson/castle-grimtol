using System;
using CastleGrimtol.Project;

namespace CastleGrimtol
{
    class Program
    {
        public static void Main(string[] args)
        {
            Game game = new Game();
            game.beginningMenu();
            game.beginJourney();
            while (game.Playing)
            {
                System.Console.WriteLine(@"Please select an action:
                Go (direction)
                2- Help
                3- Use Item
                4 -Action
                5- Inventory
                6- Reset Adventure
                7- Forefiet your Dignity
                ");

                string[] userInput = Console.ReadLine().ToLower().Split(" ");

                switch (userInput[0])
                {
                    case "go":
                        if (userInput.Length < 2)
                        {
                            System.Console.WriteLine("Please type 'go west' 'go south' 'go north' or 'go east'.");
                        }
                        else
                        {
                            game.go(userInput[1]);
                        }
                        break;
                    case "2":
                        game.help();
                        break;
                    case "3":
                        System.Console.WriteLine("Please enter the name of the item you want to use");
                        string itemName = Console.ReadLine().ToLower();
                        game.UseItem(itemName);
                        break;
                    case "4":
                        game.takeItem();
                        break;
                    case "5":
                        game.viewInventory();
                        break;
                    case "6":
                        game.Reset();
                        break;
                    case "7":
                        System.Console.WriteLine("What a shame peasant, maybe you will try harder next time");
                        game.Playing = false;
                        break;
                    default:
                        System.Console.WriteLine("Please select a valid option");
                        break;
                }
            }
            // if (Console.ReadLine() == "look")
            // {
            //     System.Console.WriteLine($"{game.CurrentRoom.Description}");
            // }
        }
    }
}
