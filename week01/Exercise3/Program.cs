using System;

class Program
{
    static void Main(string[] args)
    {
        // Generate random magic number
        Random randomGenerator = new Random();
        int magic_Number = randomGenerator.Next(1, 101); 

        int guess = -1;
        int guessCount = 0;
        
        Console.WriteLine("Welcome to the Magic Number Game! "); 
        Console.WriteLine("I'm thinking about a magic number between 1 - 100"); 
        Console.WriteLine();
        
         Console.Write("What is the magic number? "); 
         int magicNumber = int.Parse(Console.ReadLine()); 

        // Guessing loop
        while (guess != magic_Number)
        {
            Console.Write("What is your guess? "); 
            guess = int.Parse(Console.ReadLine());
            guessCount++; 

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }

            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else

            {
                Console.WriteLine("You  guessed it!  ");
                Console.WriteLine($"It took you {guessCount} guesses");    
            } 
        }






        
    }
}