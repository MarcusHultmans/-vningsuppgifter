//Skriv ett program som frågar användaren efter ett tal.
//Det ska skriva ut om talet är mindre än 100,
//lika med 100 eller större.



// Fråga användaren efter ett tal:
Console.WriteLine("Skriv ett tal");
string userNumber = "";
userNumber = Console.ReadLine();
int number = Int32.Parse(userNumber);

// Skriv ut om talet är mindre än 100
// Lika med 100
// Större än 100

if (number < 100)
{
    Console.WriteLine("Talet är mindre än 100");
}

else if (number == 100)
{
    Console.WriteLine("Talet är lika med 100");

}
else if (number > 100)
{
    Console.WriteLine("Talet är större än 100");

}




