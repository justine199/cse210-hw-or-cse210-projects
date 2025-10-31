using System;

class Program
{
    static void Main(string[] args)
    {
        // Step 1: Display welcome message
        DisplayWelcome();

        // Step 2: Get user's name
        string userName = PromptUserName();

        // Step 3: Get user's favorite number
        int userNumber = PromptUserNumber();

        // Step 4: Square the number
        int squaredNumber = SquareNumber(userNumber);

        // Step 5: Display the result
        DisplayResult(userName, squaredNumber);
    }

    // Displays a welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // Prompts for and returns the user's name
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    // Prompts for and returns the user's favorite number as an integer
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    // Squares the given number and returns the result
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // Displays the user's name and the squared number
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }
}

