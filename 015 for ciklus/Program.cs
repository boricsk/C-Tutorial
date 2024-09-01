//Ismétlődő feladatok végrehajtása
//If azerkezettel létrehozott ciklus
/*
Console.WriteLine("GOTO ciklus");
int c = 0;
ciklus:
    if (c < 10)
    {
    Console.WriteLine($"{c}");
    c++; //Így kell C++ használni C# ban
    goto ciklus;
    }
/*Nem túl jól olvasható. 
For ciklus szintaktika
for (int i = 0; i<10; i++)
{
    Ciklusmag;
}
*/

Console.WriteLine("0 -> 10");
for (int i = 0; i < 10; i++)
{
    Console.Write($"{i}, ");
}
// i-t nem lehet már definiálni, mivel forban ezt megtettük,
// de az i hatóköre a for-ra terjed ki csak ezért nem okoz gondot
// hogy több i-vel vezérelt for van egymás után 

Console.WriteLine("\n10 -> 0");
for (int i = 10; i >= 0; i--)
{
    Console.Write($"{i}, ");
}

Console.WriteLine("\n0 -> 60 Minden 3.");
for (int i = 0; i < 60; i += 3)
{
    if (i < 57)
    {
        Console.Write($"{i}, ");
    } else
    {
        Console.Write($"{i}");
    }
}

