/*
 A .NET keretrendszer lehetőséget biztosít globalizált alkalmazások készítésére. Ez azt jelenti, 
hogy a programjaink a formázott szövegeket az adott nyelvterületnek megfelelő formátumban írják ki. 
Nyelvterületenként eltérő lehet a lebegőpontos számok elválasztása, a pénznemek jelölése, a 
dátum és idő megjelenítésének formátuma és még számos más egyéb dolog.

A keretrendszerben az egyes kultúrák beállításait a CultureInfo osztály tárolja, 
amely a System.Globalization névtérben helyezkedik el.

CultureInfo objektumot háromféleképpen példányosíthatunk:

CultureInfo.CurrentUICulture;
Lekérdezi az operációs rendszer grafikus felületén (Vezérlőpult → Területi és nyelvi beállítások 
(Windows 10 esetén Régió)) beállított kultúra beállításokat.

CultureInfo.CurrentCulture;
Lekérdezi az aktuális szálra vonatkozó kultúra beállításokat. 
Ezek általában az operációs rendszer alapértelmezett beállításai, de a tálcán a nyelv 
váltással is felülbírálható egy program nyelvi beállítása.

CultureInfo.CreateSpecificCulture("en-US");
Létrehozza egy meghatározott nyelvterület beállításait. A nyelvterületet szöveges 
jelölővel kell megadni. A szabványosan elfogadott nyelvterület jelölőkről információ 
a https://msdn.microsoft.com/en-us/library/ee825488%28v=cs.20%29.aspx címen található.
A létrehozott globalizációs objektum a String.Format metódusnak átadható és a 
System.Convert osztály metódusainak is.

Az alábbi példaprogram a globalizáció használatát mutatja be:
 */

using System;
using System.Globalization;


var uiCulture = CultureInfo.CurrentUICulture;
var currentCulture = CultureInfo.CurrentCulture;
var angolCulture = CultureInfo.CreateSpecificCulture("en-US");

double d = 1.2579;

Console.WriteLine("uiCulture: {0}", uiCulture.Name);
Console.WriteLine("currentCulture: {0}", currentCulture.Name);

var current = string.Format(currentCulture, "{0}, {1}, {2:C}", d, DateTime.Now, 32580);
var angol = string.Format(angolCulture, "{0}, {1}, {2:C}", d, DateTime.Now, 32580);
Console.WriteLine(current);
Console.WriteLine(angol);

var angolFormat = Convert.ToDouble("3.14", angolCulture);
Console.WriteLine(angolFormat);

/*
Stringinfo

A Globalization névtér egy másik fontos osztálya a StringInfo, aminek a segítségével a 
szövegek valódi hosszát tudjuk megállapítani.

A C# char típusa UTF-16 karakterkódolást használ. Ez egy változó hosszúságú karakterkódolás. 
Ez azt jelenti, hogy az ábrázolandó szimbólum egy vagy két karakterből állhat, attól függően, 
hogy a kódtáblában hol helyezkedik el. A magyar ékezetes karakterek és a legtöbb európai nyelv 
esetén ez nem jelent problémát, de ha olyan alkalmazást készítünk, ami ázsiai nyelveket is támogat, 
vagy emodzsikat is támogatni szeretnénk a programunkban, akkor fel kell készülnünk, 
hogy a szöveg hossza nem azonos a benne tárolt karakterek számával.

Az alábbi példaprogram ezt mutatja be:
 */

string teszt = "🐰🐻";
Console.WriteLine("A szoveg hossza: {0}", teszt.Length);

var info = new StringInfo(teszt);
Console.WriteLine("A szoveg valodi hossza: {0}", info.LengthInTextElements);
Console.WriteLine(teszt);

