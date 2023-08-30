/* Skriv ett program som upprepade gånger frågar användaren efter ett tal ända 
till man skriver något som inte är ett tal (t.ex bara trycker enter). 
Efter varje inmatning ska summan av alla tal som matats in skrivas ut, 
innan nästa inmatning efterfrågas. Innan programmet avslutas ska man även skriva ut medelvärde av de inmatade talen. 
Hint: TryParse() */

// Fråga användaren efter ett tal

int sum = 0;
int length = 0;
int number;


while (true)
{
    Console.WriteLine("Skriv ett tal");
    bool success = int.TryParse(Console.ReadLine(), out number);
    sum += number;
    if (success)
    {
        Console.WriteLine("Summan är nu: " + sum);
    } else
    {
        Console.WriteLine("Medelvärdet blev: " + sum / length);
        Environment.Exit(0);
    }
    length++;
    

    

}
//input = Convert.ToInt32(Console.ReadLine());









// 


