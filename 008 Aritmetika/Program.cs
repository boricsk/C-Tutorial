/*
Ha short, ushort, byte vagy sbyte műveleteken végzünk eredményt, akkor azok eredménye minden esetben egy int lesz. Nézzünk egy példát:

byte a = 100;
byte b = 100;

//fordítási hiba, mivel az `int` nem implicit átalakítható byte-ra 
byte c = a * b;
 */

int a2 = 100000;
int b2 = 100000;
long c2 = a2 * b2;

/*
 Ebben az esetben azt várnánk, hogy a c2 változó értéke 10 000 000 000 legyen. 
Azonban 1 410 065 408 lesz a c2 változó értéke. Ez annak köszönhető, 
hogy a2 és b2 is 32 bites egészek, ami azt vonzza magával, hogy 32 bites 
aritmetika alapján lesznek összeszorozva, ami túlcsordul.
 */

int a3 = 100000;
int b3 = 100000;
long c3 = (long)a2 * b2;

/*
 Összegezve tehát a short, ushort, byte vagy sbyte típusok aritmetikai használata 
előtt mindig történni fog a háttérben egy implicit int típusra konvertálás, 
míg int típusról long típusra ez nem történik meg automatikusan, még akkor sem, 
ha a cél változó, amiben az eredményt tárolnánk long típusú.
 */

/*
Amennyiben fontos, hogy az egész számainkon végzett műveleteink ne járjanak 
túlcsordulással, akkor a műveleteket végezzük el checked kontextusban:
*/
checked
{
    int a4 = 100000;
    int b4 = 100000;
    long c4 = a2 * b2;
}
/*
Ha így futtatjuk a kódot, akkor futásidőben kivétel keletkezik, 
amit le tudunk kezelni megfelelően. A kivételkezelésről (try-catch) és a 
checked kontextusról a következő fejezetben lesz részletesen szó.
*/