SomeRandomPlay();
//int result = ThrowDices(2, 6);

//Console.WriteLine($"total is: { result}");

//int result2 = ThrowDices(4, 10);
//Console.WriteLine($"total is: { result2}");
//SomeIfPlay();


void SomeIfPlay()
{
    Console.WriteLine("What's your name?");
    var name = Console.ReadLine();
    Console.WriteLine("How much lines of code did you write?");
    int linesOfCode = int.Parse(Console.ReadLine());
    if (name != "Siargey" && name != "Liza" && name != "Tanya" && name != "Zhenya")
    {
        Console.WriteLine("You are not welcome on c# courses");
    }
    else if(linesOfCode<100)
    {
        Console.WriteLine("You are not welcome anymore");
    }
    else
    {
        Console.WriteLine("Welcome, take a sit");
    }
}


int ThrowDices(int numberOfDices, int numberOfSides)
{
    Random random = new Random();
    int sum = 0;
    for (int i = 0; i < numberOfDices; i++)
    {
        int randomThrow = random.Next(numberOfSides)+1;
        Console.WriteLine($"{i + 1} dice result is {randomThrow}");
        sum += randomThrow; 
    }
    return sum;
}

void SomeRandomPlay()
{
    Random myRandom = new Random();
    for (int i = 0; i < 50; i++)
    {
        int randomNumber = myRandom.Next(1, 7);
        Console.Write($"{randomNumber} ");
        if(randomNumber == 1)
        {
            break;
        }
    }
}

