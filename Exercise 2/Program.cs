﻿// Skriv ett program som frågar användaren efter ett lösenord.
// Hitta på ett hemligt lösenord och spara det i en variabel.
// När användaren har skrivit in ett lösenord ska programmet
// jämföra med det sparade lösenordet och skriva ut om det var rätt eller inte. Använd en if-sa

Console.WriteLine("Skriv lösenordet");
string secretPassword = "hej";

string userPassword = "";
userPassword = Console.ReadLine();

if (secretPassword == userPassword)
{
    Console.WriteLine("Rätt Lösenord!");
}
else
{
    Console.WriteLine("Wrong password! Note that the password only contains lowercase letters ");
}
