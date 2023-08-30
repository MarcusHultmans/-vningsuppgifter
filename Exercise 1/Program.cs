// Fråga använderen efter ett namn och ett tal
Console.WriteLine("Vad heter du?");
Console.WriteLine("Skriv ett tal");

// Ta emot namnet och talet
string name = "";
name = Console.ReadLine();

string number = "";
number = Console.ReadLine();
int numberConverted = Int32.Parse(number);


// Om det inskrivna namnet är David skriv ut "Hej David!"
if (name == "David")
{
    for (int i = 0; i < numberConverted; i++)
    {
        Console.WriteLine("Hej David!");
    }
    
}
else
{
    Console.WriteLine("Du är inte David!");
}

/*Uppdatera programmet i uppgift 1 så att det även frågar efter ett tal. 
 Skriv hälsningen så många gånger som användaren anger.*/
