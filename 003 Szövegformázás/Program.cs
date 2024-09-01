
string s = "Ez egy teszt szöveg számokkal 1234556789";

Console.WriteLine(s.Contains("X"));
Console.WriteLine(s.Contains("55"));

Console.WriteLine(s.EndsWith("X"));
Console.WriteLine(s.EndsWith("9"));

Console.WriteLine(s.IndexOf("55"));
Console.WriteLine(s.LastIndexOf("e"));

Console.WriteLine(s.Length);

string c = s.PadLeft(70,'-');
Console.WriteLine(c);
/*
 Egy új szöveget hoz létre, amely a paraméterként megadott számú karakterből áll. 
A megadott szöveg szélességen belül úgy igazítja a szöveget, hogy az balra igazított 
legyen, tehát az eredeti szöveg utolsó karaktere után annyi szóközt illeszt 
(jobb oldalról bővíti), hogy a szöveg a paraméternek megadott számú karakterből álljon. 
Kétparaméteres változatában a második paraméter a kitöltő karaktert határozza meg.
 */

c = s.PadRight(70, '-');
Console.WriteLine(c);


/*
 A megadott index pozíciótól kezdve törli a szöveg karaktereit és az eredményt 
egy új szövegként adja vissza. Kétparaméteres változatában a második paraméter 
a törlendő karakterek számát határozza meg. Az egyparaméteres változat a megadott 
indextől a szöveg végéig töröl.
 */
c = s.Remove(3, 5);
Console.WriteLine(c);

c = s.Replace("teszt", "test");
Console.WriteLine(c);

//Feldarabolás egy adott karakter mentén
string[] darabolt = s.Split(' ');
foreach (string szavak in darabolt)
{
    Console.WriteLine(szavak);
}

//Formázás
int ma = 21;
int tegnap = 18;
var szoveg = string.Format("Ma {0} fok volt, tegnap pedig {1}", ma, tegnap);

Console.WriteLine(szoveg);

Console.WriteLine("Így is lehet: {0}, {1}", ma, tegnap);

//Kiirás formázásai
Console.WriteLine("Pénz: {0:C1}", 3148);
Console.WriteLine("Százalék: {0:P3}", 0.123456);
Console.WriteLine("Általános: {0:G}", 132354);
Console.WriteLine("Exponenciális: {0:E}", 132354);
Console.WriteLine("Hexa: {0:X}", 255);

double d = 1500.42;

//1500,4200
Console.WriteLine("{0:00.0000}", d);
//(1500),42
Console.WriteLine("{0:(#).##}", d);
//1500,4
Console.WriteLine("{0:0.0}", d);
//1 500
Console.WriteLine("{0:0,0}", d);
//150042%
Console.WriteLine("{0:0%}", d);
//[Foo  ], 5 szélességre formázva, balra igazítva
Console.WriteLine("[{0,-5}]", "Foo");
//[  Foo], 5 szélességre formázva, jobbra igazítva
Console.WriteLine("[{0,5}]", "Foo");

//pozitív
Console.WriteLine("{0:pozitív;negatív;nulla}", 4);
//negatív
Console.WriteLine("{0:pozitív;negatív;nulla}", -4);
//nulla
Console.WriteLine("{0:pozitív;negatív;nulla}", 0);

//Escape karakterek elkerülése
var elso = "C:\\test\\foo";
var masodik = @"C:\test\foo";

Console.WriteLine($"{elso} {masodik}");


//többsoros raw string literal
string raw =
    """
    ez egy
    több soros
    szöveg!\t:)
    """;
Console.WriteLine(raw);

//String interpolation raw esetén

int sorok = 3;
string raw2 =
    $$"""
    ez egy interpolált
    {{sorok}} soros
    szöveg!\t:)
    """;
Console.WriteLine(raw2);

/*
 Egy literál egy olyan konkrét érték, amelyet közvetlenül beírunk a kódba. 
Például a programozási nyelvekben a literál egy állandó érték, mint egy szám, 
karakter, szöveg vagy logikai érték, amelyet a programban használnak.
 */