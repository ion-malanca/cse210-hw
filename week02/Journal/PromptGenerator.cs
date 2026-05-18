using System;

class PromptGenerator
{
    public List<string> _prompts;
    
    public PromptGenerator()
    {
        _prompts = new List<string>();
        string[] lines = System.IO.File.ReadAllLines("/Users/ionmalanca/Documents/BYU-I/CSE210 - Programming with Classes/cse210-hw/week02/Journal/prompts.csv");
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            _prompts.Add(parts[0]);
        }
    }

    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        int rand = rnd.Next(0, _prompts.Count);
        return _prompts[rand];
    }
}