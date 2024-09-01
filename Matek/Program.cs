//A Math osztályban van megvalósítva
/*

decimal     Math.Abs(decimal value);
float       Math.Abs(float value);
double      Math.Abs(double value);
int         Math.Abs(int value);
short       Math.Abs(short value);
long        Math.Abs(long value);
sbyte       Math.Abs(sbyte value);
Aszolult értékek

double Math.Acos(double val);
Inverz koszinusz számítás. A visszatérési értéke radiánban lesz kifejezve.

double Math.Asin(double val);
Inverz szinusz számítás. A visszatérési értéke radiánban lesz kifejezve.

double Math.Atan(double val);
Inverz tangens számítás. A visszatérési értéke radiánban lesz kifejezve.

decimal Math.Ceiling(decimal val);
double Math.Ceiling(double val);
A paraméterként megadott lebegőpontos szám esetén a számhoz legközelebb álló egész számot 
adja meg felfelé kerekítést alkalmazva. Tehát ha a szám rendelkezik lebegőpontos résszel, 
akkor a nála eggyel nagyobb egész érték lesz visszaadva. Például 7,001 esetén a visszatérési 
értéke 8 lesz. -7,001 esetén pedig -7

double Math.Cos(double val);
Koszinusz számítás. A paraméter szöget radiánban megadva várja.

double Math.Exp(double val);
Az Euler (e) szám a paraméterként megadott kitevőre emelve.

decimal Math.Floor(decimal val);
double Math.Floor(double val);
A paraméterként megadott lebegőpontos szám esetén a számhoz legközelebb álló egész számot adja meg lefelé kerekítést alkalmazva. Például 7,9 esetén a visszatérési értéke 7 lesz. -7,9 esetén pedig -8.

double Math.Log(double val);
double Math.Log(double val, double base);
Logaritmus számítás. Egyparaméteres változatában a logaritmus alapja az Euler (e) szám. Kétparaméteres változatában a második szám határozza meg a logaritmus alapját.

double Math.Log10(double val);
Tízes alapú logaritmus számítás.

value Math.Max(value1, value2);
Két érték közül a nagyobb értéket adja vissza.

value Math.Min(value1, value2);
Két érték közül a kisebb értéket adja vissza.

double Math.Pow(double val, double exponent);
Hatványozás. Az első paraméter a hatvány alapja, a második paraméter a hatvány kitevőt adja meg. N-edik gyök számítására is alkalmas a hatványozás szabályai alapján, ha a kitevő tört.

decimal Math.Round(decimal val);
double Math.Round(double val);
A paraméterként megadott számot a legközelebbi egész számra kerekíti a kerekítés szabályainak megfelelően.

decimal Math.Round(decimal val, int digits);
double Math.Round(double val, int digits);
Az első paraméterként megadott számot a második paraméter által meghatározott tizedes jegyre kerekíti.

double Math.Sin(double val);
Szinusz számítás. A paraméter szöget radiánban megadva várja.

double Math.Sqrt(double val);
Négyzetgyökvonás.

double Math.Tan(double val);
Tangens számítás. A paraméter szöget radiánban megadva várja.

decimal Math.Truncate(decimal val);
double Math.Truncate(double val);
Kerekítés nélkül visszaadja a paraméterként megadott lebegőpontos szám egész részét, vagyis levágja a tizedesjegyeket.

Konstansok
Math.PI
Math.E
*/


Console.WriteLine(Math.Abs(12));
Console.WriteLine(Math.Acos(12));
Console.WriteLine(Math.Asin(12));
Console.WriteLine(Math.Atan(12));
Console.WriteLine(Math.Ceiling(12.98));
Console.WriteLine(Math.Ceiling(12.2));
Console.WriteLine(Math.Cos(12));
Console.WriteLine(Math.Floor(12.02));
Console.WriteLine(Math.Max(12,158));
Console.WriteLine(Math.Min(12,158));
Console.WriteLine(Math.Pow(12, 158));
Console.WriteLine(Math.Round(12.158));
Console.WriteLine(Math.Min(12, 158));
Console.WriteLine(Math.PI);
Console.WriteLine(Math.E);

var sugar = 12;
Console.WriteLine("Kör kerület és terület számító.");
Console.WriteLine("Kör sugara: {0}", sugar);

var kerulet = Math.PI * 2 * sugar;
var terulet = Math.Pow(sugar, 2) * Math.PI;

Console.WriteLine("A kör kerülete: {0}", kerulet);
Console.WriteLine("A kör területe: {0}", terulet);


Console.WriteLine(long.MaxValue);
Console.WriteLine(int.MaxValue);