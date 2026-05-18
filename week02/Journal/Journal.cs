using System;
using System.IO;

class Journal
{
    public List<Entry> entries;
    public Journal()
    {
        entries = new List<Entry>();
    }
    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }
    public void DisplayJournal()
    {
        foreach(Entry entry in entries)
        {
            Console.WriteLine(entry.DisplayEntry());
        }
    }
    public void WriteToFile(string filename)
    {
        string path = $"/Users/ionmalanca/Documents/BYU-I/CSE210 - Programming with Classes/cse210-hw/week02/Journal/{filename}.csv";
        using (StreamWriter outputFile = new StreamWriter(path))
        {
            foreach (Entry entry in entries)
            {
                outputFile.WriteLine($"{entry._prompt},");
                outputFile.WriteLine($"{entry._response},");
                outputFile.WriteLine($"{entry._date},");
            }
        }
    }
    public void ReadFromFile(string filename)
    {
        entries.Clear();
        string[] lines = System.IO.File.ReadAllLines($"/Users/ionmalanca/Documents/BYU-I/CSE210 - Programming with Classes/cse210-hw/week02/Journal/{filename}.csv");
        for (int i = 0; i < lines.Length; i += 3)
        {
            string prompt = lines[i].TrimEnd(',');
            string response = lines[i + 1].TrimEnd(',');
            string date = lines[i + 2].TrimEnd(',');
            Entry entry = new Entry(prompt, response, date);
            entries.Add(entry);
        }
    }

    public void SearchEntries(string keyword)
    {
        foreach (Entry entry in entries)
        {
            if (entry._response.Contains(keyword))
            {
                entry.DisplayEntry();
            }
        }
    }

    public void DeleteEntry()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No entries to delete.");
            return;
        }
        Console.WriteLine("Journal Entries:");
        for (int i = 0; i < entries.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {entries[i]._date} - {entries[i]._prompt}");
        }
        Console.Write("Select entry number to delete: ");
        int choice = int.Parse(Console.ReadLine());
        if (choice >= 1 && choice <= entries.Count)
        {
            entries.RemoveAt(choice - 1);
            Console.WriteLine("Entry deleted.");
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }
    }
}