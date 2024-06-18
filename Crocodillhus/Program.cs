void Main()

{

    int rando = rand();
    int randy = rand();
    Console.WriteLine("Welcome to the game!");
    Console.WriteLine($"{rando} _ {randy}");
    string userInput = Console.ReadLine();
    
    if(rando == randy)
    {
        if(userInput == "=")
        {
            Console.WriteLine("That's correct!");
        }
        else
        {
            Console.WriteLine("You got that wrong!");
        }
    }
    else if(rando < randy)
    {
        if (userInput == "<") 
        {
            Console.WriteLine("That's correct!");
        } 
        else
        {
            Console.WriteLine("You got that wrong!");
        }
    }
    else if (rando > randy)
    {
        if (userInput == ">")
            {
            Console.WriteLine("That's correct!");
            }
        else 
        {
            Console.WriteLine("You got that wrong!");
        }
    }


}
Main();

int rand()
{
    var rnd = new Random();
    var rndNumber = rnd.Next(0, 11);
    return rndNumber;
}


