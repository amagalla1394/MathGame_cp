namespace MathGame
{
    internal class Menu
    {
        internal void ShowMenu(string name, DateTime date)
        {
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine($"Hello {name}. It's {date.DayOfWeek}. This is your math game. That's great that you're working on improving yourself\n");

            bool isGmaeOn = true;

            do
            {
                Console.Clear();
                Console.WriteLine($@"What game would you like to play today? Choose from the options below:
            V - View Previous Games
            A - Addition
            S - Subtraction
            M - Multiplication
            D - Division
            R - Random (Currently under maintenance)
            Q - Quit the program");
                Console.WriteLine("------------------------------------------------------------");


                var gameSelected = Console.ReadLine();

                switch (gameSelected.Trim().ToLower())
                {
                    case "v":
                        GetGames();
                        break;
                    case "a":
                        AdditionGame("Addition game");
                        break;
                    case "s":
                        SubtractionGame("Subtraction game");
                        break;
                    case "m":
                        MultiplicationGame("Multiplication game");
                        break;
                    case "d":
                        DivisionGame("Division game");
                        break;
                    //case "r":
                    //  RandomGame("Random game");
                    //break;
                    case "q":
                        Console.WriteLine("Goodbye");
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        isGmaeOn = false;
                        break;
                }
            } while (isGmaeOn);

        }
    }
}
