//Calculator Math Game
//Prompt user:
Console.WriteLine("Please type your name: ");
var name = Console.ReadLine();
var date = DateTime.UtcNow;

Menu(name, date);
void Menu(string? name, DateTime date)
{
    Console.WriteLine("-----------------------------------------------------------");
    Console.WriteLine($"Hello {name}. It's {date.DayOfWeek}. This is your math game. That's great that you're working on improving yourself\n");
    Console.WriteLine($@"What game would you like to play today? Choose from the options below:
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quit the program");
    Console.WriteLine("------------------------------------------------------------");


    var gameSelected = Console.ReadLine();

    switch (gameSelected.Trim().ToLower())
    {
        case "a":
            AdditionGame("Addition game selected");
            break;
        case "s":
            SubtractionGame("Subtraction game selected");
            break;
        case "m":
            MultiplicationGame("Multiplication game selected");
            break;
        case "d":
            DivisionGame("Division game selected");
            break;
        case "q":
            Console.WriteLine("Goodbye");
            Environment.Exit(1);
            break;
        default:
            Console.WriteLine("Invalid Input");
            Environment.Exit(1);
            break;
    }
}

void AdditionGame(string message)
{
    Console.WriteLine("Addition game selected");
}
void SubtractionGame(string message)
{
    Console.WriteLine("Subtraction game selected");
}
void MultiplicationGame(string message)
{
    Console.WriteLine("Multiplication game selected");
}
void DivisionGame(string message)
{
    Console.WriteLine("Division game selected");
}
