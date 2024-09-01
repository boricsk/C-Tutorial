//Ugrás a megadott cimkével ellátott részre.

Console.WriteLine("Goto példa. Kilépés: CTRL+C");
eleje:
    Console.WriteLine("Add meg a neved");
    var nev = Console.ReadLine();
    Console.WriteLine($"Szia {nev}!");
    goto eleje;


