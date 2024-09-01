/*
 Feltételes utasításvégrehajtás, ha a feltétel igaz akkor lesz végrehajtva a blokkban lévő utasítás,
egyébként az else ág fut le.
Az if-ek egymásba ágyzhatóak else if -el.
 */

Console.WriteLine("Kérem adjon meg egy számot!");
var bevitel = Console.ReadLine();

int x = Convert.ToInt32(bevitel);

if (x >= 20) Console.WriteLine("Nagyobb, vagy egyenlő , mint 20");
else if (x >= 10) Console.WriteLine("Nagyobb, vagy egyenlő, mint 10");
else Console.WriteLine("Kisebb, mint 10");

//Komplex feltétel, zárójelezés fontos!
if (((x % 2) == 0) && (x > 0))
{
    Console.WriteLine("A megadott szám páros és nem nulla");
}
else Console.WriteLine("Páratlan vagy nulla");

/*
 &&, || és a & , | közötti különbségek
Nem kapunk fordítási hibát, ha a && jel helyett csak egy & jelet teszünk. 
Ugyanígy akkor sem kapunk hibát, ha a || jelet kicseréljük egy | jelre.

Azonban két különböző típusú viselkedést tapasztalunk. A duplázott jelek 
úgynevezett rövidre zárt (short circuited) operátorok. Ez azt jelenti, hogy 
a kifejezés kiértékelés szempontjából optimalizáltak. Ennek bemutatására nézzük 
meg az alábbi kódot:
 */
static bool Teszt1()
{
    Console.WriteLine("Teszt1 kiértékelése...");
    return false;
}

static bool Teszt2()
{
    Console.WriteLine("Teszt2 kiértékelése...");
    return true;
}

if (Teszt1() & Teszt2())
{
    //Mindkét metódus lefut a tesztelés közben
}
Console.WriteLine();

if (Teszt2() | Teszt1())
{
    //Mindkét metódus lefut a tesztelés közben
}
Console.WriteLine();

if (Teszt1() && Teszt2())
{
    //Teszt2 nem hívódik meg
}
Console.WriteLine();

if (Teszt2() || Teszt1())
{
    //Teszt1 nem hívódik meg
}

/*
 A kódban Teszt1() és Teszt2() metódusok. Ezek létrehozásáról a későbbiekben lesz szó. 
A kódban a lényegi rész az eddig tanult if szerkezet. Az első két esetben azt tapasztaljuk, 
hogy az operátor jobb és bal oldalán álló metódus is meghívódik. Az első és kapcsolatot 
tartalmazó if esetében azonban bőven elég lenne meghívni az első metódust, mivel az hamis 
értéket ad vissza. Ebből következően Teszt2 lefuttatása felesleges, mert ha az még igaz 
értéket is adna vissza, akkor sem teljesülne a feltétel.

A második esetben szintén lehetne jobb a végrehajtás. Itt Teszt2 hívódik a példa kedvéért, 
ami igaz értéket ad vissza. A vagy művelet igazságtáblázatából kikövetkeztethető, hogy ha 
egy kifejezés rendelkezik egy igaz taggal, akkor az a kifejezés mindig igaz lesz. Tehát 
ebben az esetben felesleges Teszt1 hívása.

A harmadik és negyedik if esetén tapasztaljuk a duplázott operátorok jelentőségét. 
A harmadik esetben csak Teszt1 fut le, míg a negyedik esetben csak Teszt2 fut le, 
a korábban említett okokból kifolyólag.
 */