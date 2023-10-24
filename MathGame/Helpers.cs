using MathGame.Models;

namespace MathGame
{
    internal class Helpers
    {
        internal static List<Game> games = new List<Game>
        {
            new Game { Date = new DateTime.Now.AddDays(1), Type = GameType.Addition, Score = 5 },
            new Game { Date = new DateTime.Now.AddDays(2), Type = GameType.Subtraction, Score = 6 },
            new Game { Date = new DateTime.Now.AddDays(3), Type = GameType.Multiplication, Score = 3 },
            new Game { Date = new DateTime.Now.AddDays(4), Type = GameType.Addition, Score = 7 },
            new Game { Date = new DateTime.Now.AddDays(5), Type = GameType.Division, Score = 2 },
            new Game { Date = new DateTime.Now.AddDays(6), Type = GameType.Subtraction, Score = 1 },
        };

        internal static void PrintGames()
        {
            var gamesToPrint = games.Where(x => x.Type == GameType.Division);

            Console.Clear();
            Console.WriteLine("Games History");
            Console.WriteLine("-------------------------");
            foreach (var game in games)
            {
                Console.WriteLine($"{game.Date} - {game.Type}: {game.Score}pts");
            }

            Console.WriteLine("-------------------------\n");
            Console.WriteLine("Press any key to return to the Main Menu");
            Console.ReadLine();
        }

        internal static void AddToHistory(int gameScore, GameType gameType)
        {
            games.Add(new Game
            {
                Date = DateTime.Now,
                Score = gameScore,
                Type = gameType
            });
        }

        internal static int[] GetDivisionNumbers()
        {
            var random = new Random();
            var firstNumber = random.Next(0, 99);
            var secondNumber = random.Next(0, 99);

            while (firstNumber % secondNumber != 0)
            {
                firstNumber = random.Next(1, 99);
                secondNumber = random.Next(1, 99);
            }

            var result = new int[2];

            result[0] = firstNumber;
            result[1] = secondNumber;

            return result;
        }
    }
}
