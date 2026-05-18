// EXTRA CREDIT
// I added a search feature that allows users to search journal entries by keyword.
// I added a delete feature that allows users to remove specific journal entries from the journal.

using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        int input = 0;
        do
        {

            Console.WriteLine("What would you like to do? ");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save journal to a file");
            Console.WriteLine("4. Populate journal from a file");
            Console.WriteLine("5. Search entries");
            Console.WriteLine("6. Remove entry");
            Console.WriteLine("7. Exit Menu");

            input = int.Parse(Console.ReadLine());
            if (input == 1)
            {
                PromptGenerator promptGenerator = new PromptGenerator();
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                string response = Console.ReadLine();
                DateTime theCurrentTime = DateTime.Now;
                string date = theCurrentTime.ToShortDateString();
                Entry entry = new Entry(prompt, response, date);
                journal.AddEntry(entry);
            } else if (input == 2)
            {
                journal.DisplayJournal();
            } else if (input == 3)
            {
                Console.Write("File name: ");
                string fileName = Console.ReadLine();
                journal.WriteToFile(fileName);
            } else if (input == 4)
            {
                Console.Write("File Name: ");
                string fileName = Console.ReadLine();
                journal.ReadFromFile(fileName);
            } else if (input == 5)
            {
                Console.Write("Keyword: ");
                string keyword = Console.ReadLine();
                journal.SearchEntries(keyword);
            } else if (input == 6)
            {
                journal.DeleteEntry();
            } else if (input == 7)
            {
                break;
            } else
            {
                Console.WriteLine("Please select an item from the menu");
            }

        } while (input != 7);

        Console.WriteLine("Thank you!");
    }
}