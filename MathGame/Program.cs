﻿using System;

//Calculator Math Game
//Prompt user for selection:
Console.WriteLine("Please type your name: ");
var name = Console.ReadLine();
var date = DateTime.UtcNow;

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

if(gameSelected.Trim().ToLower() == "a")
{
    AdditionGame();
}
else if (gameSelected.Trim().ToLower() == "s")
{
    SubtractionGame();
}
else if (gameSelected.Trim().ToLower() == "m")
{
    MultiplicationGame();
}
else if (gameSelected.Trim().ToLower() == "d")
{
    DivisionGame();
}
else if (gameSelected.Trim().ToLower() == "q")
{
    ExitGame();
}
else
{
    Console.WriteLine("Invalid Input");
}

void AdditionGame()
{
    Console.WriteLine("Addition game selected");
}
void SubtractionGame()
{
    Console.WriteLine("Subtraction game selected");
}
void MultiplicationGame()
{
    Console.WriteLine("Multiplication game selected");
}
void DivisionGame()
{
    Console.WriteLine("Division game selected");
}
void ExitGame()
{
    Console.WriteLine("Goodbye");
    Environment.Exit(1);
}