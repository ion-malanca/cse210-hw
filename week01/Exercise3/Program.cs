using System;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        String doing = "Yes";
        while (doing == "Yes") {
            int magicNUmber = rnd.Next(1, 101); 
            int guess;
            int counter = 0;
            do
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                if (guess < magicNUmber)
                {
                    Console.WriteLine("Higher");
                } else if (guess > magicNUmber)
                {
                    Console.WriteLine("Lower");
                } else
                {
                    Console.WriteLine("You guessed it!");
                }
                counter++;
            } while (guess != magicNUmber);
            Console.WriteLine("You have maid " + counter + " guesses");
            Console.Write("Do you want to play again (Yes / No)? ");
            doing = Console.ReadLine();
        };
    }
}