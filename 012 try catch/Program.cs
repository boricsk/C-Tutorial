/*
Futás alatti hibák kezelésére szolgál

string szoveg = "valami szöveg";
int szam = Convert.ToInt32(szoveg); //itt hiba lesz
Console.WriteLine(szam);
Console.ReadKey();

Szintaktika
try
{
  //védett utasítások.
}
catch (kivétel_típusa)
{
  //hibakezelés
}

A try blokk tartalmazza a kivételkezeléssel védett utasításokat. 
Ha a program végrehajtása közben valami hiba lép fel, akkor a try 
blokkhoz rendelt catch hibakezelőbe akkor kerül a vezérlés, ha a 
catch feltételben meghatározott típusú hiba lép fel.

Az összes kivételeset, amit kezelhetünk, az Exception osztályból 
származik, amely rendelkezik egy szöveges leírással és jó néhány 
nyomkövetési információval, amivel megkönnyíthető a hiba megkeresése. 
Az előző példában megírt alkalmazásunk kivétel kezelt változata:
*/

try
{
    string szoveg = "valami szöveg";
    int szam1 = Convert.ToInt32(szoveg);
    Console.WriteLine(szam1);

}
catch (FormatException ex)
{
    Console.WriteLine("Valami hiba történt: {0}", ex.Message);
}
catch (DivideByZeroException ex1)
{
    Console.WriteLine("Valami másik típusú hiba történt: {0}", ex1.Message);
}

/*
 Egy try blokk után több catch blokk is jöhet a különböző típusú hibák 
elkapására és kezelésére. Ha több catch blokk van, akkor a legelső, 
ami tudja kezelni a kivételt, fog lefutni. Emiatt lényeges, hogy 
milyen sorrendben vannak definiálva az egyes catch ágak.

Írhattam volna a blokkba Exception típust is, mivel az minden jellegű 
hibát elkap, viszont ennek a túlzásba vitele nem a legjobb programozói gyakorlat.

Ha nagyobb részeket szeretnénk általános Exception elkapással védeni, 
akkor abba a helyzetbe kerülhet a felhasználó, hogy kap egy hibaüzenetet, 
de nem tudja konkrétan az okát, hogy miért. Ezért igyekezzünk a kivételkezelő 
blokkjainkat informatívvá tenni, illetve csak a megfelelő típusú hibák 
elkapására szorítkozni, ha lehetőségünk van.

Az informatívvá tétel egyik lehetősége, hogy az összes Exception osztályból 
leszármaztatott hiba rendelkezik Message tulajdonsággal, ami a hiba típusáról 
ad egy rövid szöveges összefoglalást. Az alábbi felsorolás a .NET fontosabb 
beépített hiba osztályait tartalmazza és egy rövid leírást arról, hogy mikor 
következhet be a hiba:

AccessViolationException
Olyankor lép fel, ha olyan memória területet szeretnénk írni vagy olvasni, amihez nincs hozzáférésünk.

ArgumentException
Akkor futhatunk bele, ha egy metódusnak nem megfelelő paramétereket próbálunk átadni. Leginkább programozói hiba. Ezt kód módosítással kezelni kell.

ArgumentNullException
Akkor futhatunk bele, ha egy metódus egyik paraméterének null értéket próbálunk átadni.

ArgumentOutOfRangeException
Akkor keletkezik, amikor egy metódus egyik paraméterének átadott érték a lehetséges értékek halmazán kívül esik.

ArithmeticException
Általános műveleti hiba. Leginkább konvertáláskor, műveletvégzéskor léphet fel.

DivideByZeroException
Nullával való osztáskor fellépő hiba.

FormatException
Szöveggé alakításkor és szöveg feldolgozáskor fellépő hiba. Azt jelzi, hogy a szöveges formátum nem megfelelő.

IndexOutOfRangeException
Tömb alul vagy felül indexeléskor fellépő hiba.

InsufficientMemoryException
Akkor lép fel, amikor az előzetes memória vizsgálat szerint nincs elegendő memória a művelet elvégzéséhez.

InvalidCastException
Akkor lép fel, ha nem megfelelően konvertálunk adattípusok között. Például, ha statikusan szeretnénk szövegből int-re konvertálni.

NotSupportedException
Akkor lép fel, ha végrehajtani kívánt művelet az objektum jelenlegi állapotában nem támogatott.

NullReferenceException
Abban az esetben lép fel, ha a változó, amire a kódrészletünkben hivatkozunk null értékű, de nem kellene neki annak lennie.

OutOfMemoryException
A programunk futás közben kifogyott a memóriából.

StackOverflowException
Tipikusan akkor fordul elő, ha egy metódusunk rekurzívan saját magát hívja végtelen ciklusban

IOException
Fájlkezelési műveletek sikertelensége esetén bekövetkező hiba típus.


A kódunkból dobhatunk mi is kivételeket. Erre a throw kulcsszó szolgál. 
A throw kulcsszó után egy Exception leszármaztatott osztály példányosításának 
kell állnia. A throw kulcsszó önmagában is alkalmazható, de csak egy catch 
blokkon belül. Ezt leginkább akkor szokták alkalmazni, ha a hibát lokálisan 
csak naplózással szeretnénk lekezelni.
 */

try
{
    string szoveg = "valami szöveg";
    int szam2 = Convert.ToInt32(szoveg);
    Console.WriteLine(szam2);

}
catch (Exception ex)
{
    Console.WriteLine("Valami hiba történt: {0}", ex.Message);
    throw; //hibát tovább dobjuk.
}

/*
 Ebben az esetben ugyanúgy kihal a program.
Felmerülhet jogosan a kérdés, hogy akkor ennek mi értelme így? Ha kivétel keletkezik 
és lokális szinten Exception (minden kivétel őse) típusra kezelünk, mert nem vagyunk 
biztosak abban, hogy milyen kivétel keletkezhet, akkor sosem célszerű elkapni a kivételt, 
mert sok hiba elnyelődhet, aminek a felderítése igen körülményes tud lenni. Éppen 
ezért úgy célszerű alkalmazást létrehozni, hogy legyen egy globális hibakezelő 
try-catch blokk, ami eldöntheti, hogy az adott hiba fennállása mellett futhat-e 
egyáltalán tovább a program, vagy sem.
 
Finally blokk
A try blokk után állhat egy finally blokk is. A finally blokk opcionális része a 
kivételkezelésnek. A benne elhelyezett kód akkor is lefut, ha a vezérlés átkerül a 
catch blokkba. Leginkább olyan esetekben van értelme a használatának, ha kivétel 
esetén is fel szeretnénk szabadítani az erőforrást, amit használunk.

Erre jó példa lehet fájlkezeléskor, hogy írunk egy fájlt, amibe az írás valamilyen 
okból kifolyólag meghiúsul. Ekkor a vezérlés átkerül a catch ágba, megjelenítjük a
hibát. Viszont a fájl nyitva maradhat, ami ahhoz vezet, hogy más programok nem 
férhetnek hozzá a tartalmához egészen addig, amíg be nem zárjuk a programunkat.

Az alábbi példa a saját kivétel dobást és a finally blokk használatát mutatja be:
 */

Console.WriteLine("Kettővel szorzó v. 1.0");
Console.WriteLine("Adjon meg egy egész páros számot!");
try
{
    var bevitel = Console.ReadLine();
    int szam3 = Convert.ToInt32(bevitel);

    if ((szam3 % 2) != 0)
    {
        throw new Exception("A szám nem páros");
    }
    Console.WriteLine($"A szorzás eredménye: {szam3 * 2}");

}
catch (Exception ex)
{
    Console.WriteLine("HIBA történt");
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("Program vége. Nyomjon egy gombot a kilépéshez");
    Console.ReadKey();
}

/*
 Mit érdemes kivételkezelni?

A futás idejű hibák egy része kivédhető már a szoftver megírása közben. 
Például jelen esetben előre fel lehet készülni arra, hogy ha a felhasználónak 
lesz lehetősége beírni számnak azt, hogy ASD, akkor meg is fogja tenni. 
Éppen ezért az ilyen hibákra már az elején érdemes felkészülni és nem 
kivételkezelő blokkokkal, hanem olyan metódusokkal, amelyek nem dobnak 
kivételt ilyen esetben.

Erre egy jó példa az int típus TryParse metódusa, ami egy igaz értéket 
ad vissza, ha a bemenetként adott szöveget sikerült feldolgoznia számként. 
A feldolgozott számot pedig egy out paraméterben adja vissza:
 */

int szam4;
if (int.TryParse("123", out szam4))
{
    //sikeres volt a feldolgozás
    //ebben a blokkban a szam változó
    //biztos, hogy helytálló értékkel rendelkezik.
}
