
/*
 A lebegőpontos számok felbontása véges, ezért nem minden szám egyforma pontossággal ábrázolható. 
Ez a pontatlanság akkor okoz nekünk problémát, ha a == operátorral szeretnénk két lebegőpontos 
számot összehasonlítani. Nézzünk erre egy példát:
 */

double doubleX = 0d;
for (int i = 0; i < 10; i++)
{
    doubleX += 0.1d;
    Console.WriteLine(doubleX);
}
doubleX *= 8d;
double doubleY = 8d;

Console.WriteLine("Double:");
Console.WriteLine(doubleX);
Console.WriteLine(doubleY);
Console.WriteLine("doubleX == doubleY: {0}", doubleX == doubleY);

float floatX = 0f;
for (int i = 0; i < 10; i++)
{
    floatX += 0.1f;
}
floatX *= 8f;
float floatY = 8f;

Console.WriteLine();
Console.WriteLine("Float:");
Console.WriteLine(floatX);
Console.WriteLine(floatY);
Console.WriteLine("floatX == floatY: {0}", floatX == floatY);

/*
 lebegőpontos számokat sose hasonlítsunk össze a == operátorral, mert több, mint valószínű 
nem az fog történni, amire számítunk.

 Kérdés már csak az, hogy akkor mégis hogyan lehetne megvizsgálni, hogy két szám nagyjából 
egyenlő-e? A kulcs a nagyjából egyenlőn van. Két lebegőpontos szám összehasonlításakor 
mindig egy adott tűréshez kell hasonlítani:
*/

double diff = 0.01;
double x = doubleX;
double y = doubleY;

Console.WriteLine(Math.Abs(x-y) < diff);

/*
Az Abs hívás azért kell, mivel a két szám esetén nem tudhatjuk előre, hogy melyik lesz a 
nagyobb, így kivédjük a negatív számokat. Ha pedig a kapott eredmény kisebb, mint az 
előre meghatározott tűrés (diff), akkor a két szám egyenlőnek tekinthető.
 */