//int age = 27;
//string name = "Marcus";

//if (age < 25)
//{
//    Console.WriteLine("Du är över 25");
//}
//else if (name == "Marcus")
//{
//    Console.WriteLine("oj");
//}
//else
//{
//    Console.WriteLine("Du är ung");
//}

//// Loopar

//int counter = 0;

//// while loop
//while (name == "Marcus")
//{
//    if (counter >= 10)
//    {
//        break;
//    }
//    Console.WriteLine("LOL");
//    counter++;
//}
//Console.WriteLine("______________");

//// Gör samma med en for loop
//for (int i = 0; i < 10; i++)
//{
//    if (name != "Marcus")
//    {
//        break;
//    }
//    Console.WriteLine("Lol");
//}

// En array med 10 platser i sig.
int[] goodNumbers = new int[10];

for (int i = 0; i < goodNumbers.Length; i++)
{
    goodNumbers[i] = i + 1;
}

Array.Sort(goodNumbers);


//foreach(int number in goodNumbers)
//{
//    Console.WriteLine(number);
//}

//int index = 0;

//while (index < goodNumbers.Length)
//{
//    index++;
//}

//string name = "Marcus";
//Console.WriteLine(name.Length);
//Console.WriteLine(name[2]);

//for (int i = 0; i < name.Length; i++)
//{
//    Console.WriteLine(name[i]);
//}


