using System.Reflection.Metadata.Ecma335;
Console.WriteLine("Welcome to the Grand Circus Casino!");
Console.WriteLine("How many sides should each die have");
run();



void run()
{
    int returnvalue1, returnvalue2, sides;

    while (true)
    {
        int rollNumber = 1;
        roll(out returnvalue1, out returnvalue2, out sides);
        combo( returnvalue1,  returnvalue2, sides);
        Console.WriteLine("Would you like to play again? y or n");
        string answer = Console.ReadLine();
        answer.ToLower();

        if (answer == "y")
        {
            rollNumber++;
            Console.WriteLine($"Roll {rollNumber}");
            continue;
        }
        else
        {
            Environment.Exit(0);
            break;
        }
    }
}


void roll(out int returnvalue1, out int returnvalue2, out int sides)
{
    
    Random random1 = new Random();
    Random random2 = new Random();
     sides = Convert.ToInt32(Console.ReadLine());
     returnvalue1 = random1.Next(1,sides);  
     returnvalue2 = random2.Next(1,sides);
    Console.WriteLine($"you rolled a {returnvalue1} and a {returnvalue2} {returnvalue1 + returnvalue2} Total" );
}

void combo( int returnvalue1, int returnvalue2, int sides)
{
    Console.WriteLine(returnvalue1);

    if (sides == 6)
    {

        if (returnvalue1 + returnvalue2 == 2)
        {
            Console.WriteLine("Snake Eyes");
        }

        else if (returnvalue1 + returnvalue2 == 3)
        {
            Console.WriteLine("Ace Deuce");
        }

        else if (returnvalue1 == 6 && returnvalue2 == 6)
        {
            Console.WriteLine("Box Cars");
        }

        else if (returnvalue1 + returnvalue2 == 7 || returnvalue1 + returnvalue2 == 11)
        {
            Console.WriteLine("Win");
        }

        else if (returnvalue1 + returnvalue2 == 2 || returnvalue1 + returnvalue2 == 3 || returnvalue1 + returnvalue2 == 12)
        {
            Console.WriteLine("Craps");
        }
        else
        {
            Console.WriteLine("");
        }
    }


    

   
}
