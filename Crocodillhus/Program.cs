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








// that way of doing the switch doesn't work. change it to something else, because it has to apply to each one. < won't always be right you donkey.
// it needs to check randy & rando somehow. do an if/else inside the switch?!
// Make a new random, between 1-11
// show two randoms in the console, with a space between them filled by an underscore numb _ numb
// have the userInput be letting them write in >, < or =
// make a if/else to check if they got it right, perhaps a switch instead because they're cooler
// probably give a note saying if it's right








/*Oppgave: Krokodillespillet


Du skal bruke det du har lært til å programmere “krokodille spillet”.

For hver runde skal det printes ut til skjermen et random tall mellom 1-11, et mellomrom og et nytt tall mellom 1-11 med en underscore mellom slik at det ser sånn ut: 3 _ 5

Brukeren kan skrive inn <, > eller =

i tilfellet brukeren får 3 _ 5 vil svaret være <, altså 3 < 5

Tallene må sjekkes om det første er større eller mindre eller lik det andre tallet,
Det må verifiseres om brukeren har valgt riktig alternativ.
Brukeren får et poeng per riktig svar, og mister et poeng per feil svar.
Poengsummen printes til skjermen for hvert svar brukeren har gitt.
Spillet avsluttes når brukeren skriver inn noe annet enn de tre alternativene*/