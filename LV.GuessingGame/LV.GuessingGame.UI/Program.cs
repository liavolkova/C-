string? playAgain = "yes";
while (playAgain == "yes" || playAgain == "y")
{

    int min = 1;
    int max = 100;
    Random random = new Random();


    int number = random.Next(min, max + 1); // 1-100
    //Console.WriteLine("---->" + number);

    int guess = 0;
    int numberofGuesses = 0;

    while (number != guess)
    {
        Console.Write("Guess a number: ");
        string? input = Console.ReadLine();

        if (int.TryParse(input, out guess) && guess >= min && guess <= max)
        {
            if (guess < number)
            {
                Console.WriteLine("My number is bigger");
            }
            else if (guess > number)
            {
                Console.WriteLine("My number is smaller");
            }
        }
    }
    Console.WriteLine("Yes! " + number + " is my number");

    if (numberofGuesses > 1)
    {
        Console.WriteLine("You've got it in " + numberofGuesses + " guesses");
    }
    else
    {
        Console.WriteLine("You've got it in 1 guess!");
    }
    
 
    playAgain = Console.ReadLine()?.ToLower()?.Trim();

}
