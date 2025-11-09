using System;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        string userChoice = "";

        while (userChoice != "5")
        {
            Console.WriteLine("Journal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("Enter your choice: ");
            userChoice = Console.ReadLine();
            Console.WriteLine();

            if (userChoice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("Your response: ");
                string response = Console.ReadLine();

                Entry newEntry = new Entry
                {
                    _date = DateTime.Now.ToShortDateString(),
                    _prompt = prompt,
                    _response = response
                };

                theJournal.AddEntry(newEntry);
            }
            else if (userChoice == "2")
            {
                theJournal.DisplayAll();
            }
            else if (userChoice == "3")
            {
                Console.Write("Enter filename to save (e.g., journal.txt): ");
                string filename = Console.ReadLine();
                theJournal.SaveToFile(filename);
            }
            else if (userChoice == "4")
            {
                Console.Write("Enter filename to load: ");
                string filename = Console.ReadLine();
                theJournal.LoadFromFile(filename);
            }
            else if (userChoice == "5")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.\n");
            }
        }
    }
}
