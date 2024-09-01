// A DateTime osztályt lehet erre használni.
//Ha kivonjuk vagy összeadjuk a datetime-ot akkor TimeSpan osztály lesz belőlle
//ez intervallum leírására van.

Console.WriteLine(DateTime.Now);
Console.WriteLine(DateTime.Today);
Console.WriteLine(DateTime.UtcNow);

DateTime date;
date = DateTime.Now;
Console.WriteLine(date);

int year = date.Year;
int month = date.Month; 
int day = date.Day; 
int dayOfYear = date.DayOfYear;
int hour = date.Hour;
int min = date.Minute;
int sec = date.Second;
int milisec = date.Millisecond;

//Ez enum típusú
DayOfWeek dow = date.DayOfWeek;
Console.WriteLine(dow);

/*
 Fomázott megjelenítés
Jelölő 	Leírás
d 	    Rövid dátum, a hónap számmal
D 	    Hosszú dátum, a hónap neve szövegként
t 	    Rövid idő másodperc nélkül
T 	    Hosszú idő másodperc megjelenítéssel
f 	    Teljes dátum és idő. Hónap neve szöveggel.
F 	    Teljes dátum és idő. Idő esetén a másodpercet is mutatja.
g 	    Alapértelmezett dátum és idő formátum. Hónap számmal.
G 	    Alapértelmezett dátum és idő formátum. Idő esetén a másodpercet is mutatja.
M 	    Hónap és nap. A hónap szövegesen
r 	    RFC1123 szerinti dátum szöveg
Y 	    Év és hónap. A hónapot szövegesen írja ki.

Egyedi leírók létrehozásához
Jelölő 	Leírás
dd 	    Nap
ddd 	Három betűs nap rövidítés
dddd 	Az adott nap szövegesen
hh 	    Óra megjelenítése két számjegyen, 12 órás formátumban
HH 	    Óra megjelenítése két számjegyen, 24 órás formátumban
mm 	    Percek megjelenítése
MM 	    Hónap megjelenítése
MMM 	Három betűs hónap rövidítés
MMMM 	Hónap neve szövegesen
ss 	    Másodpercek kijelzése
tt 	    Napszak kijelzése. Délelőtt vagy Délután lehet
yy 	    Év utolsó két számjegye
yyyy 	Év négy számjegyen
zz 	    Időzóna eltolódás két számjegyen
 */

var ido = DateTime.Now;

Console.WriteLine("Rövid dátum:         {0:d}", ido);
Console.WriteLine("Hosszú dátum         {0:D}", ido);
Console.WriteLine("Rövid idő            {0:t}", ido);
Console.WriteLine("Hosszú idő           {0:T}", ido);
Console.WriteLine("Teljes dátum         {0:f}", ido);
Console.WriteLine("Mégteljesebb dátum   {0:F}", ido);
Console.WriteLine("Alapértelmezett      {0:g}", ido);
Console.WriteLine("Alapértelmezett      {0:G}", ido);
Console.WriteLine("Hónap és nap         {0:M}", ido);
Console.WriteLine("RFC1123              {0:r}", ido);
Console.WriteLine("Év és hónap          {0:Y}", ido);
Console.WriteLine("Egyedi : {0:yyyy-mm-dd, dddd tt hh:mm:ss}", ido);


//Csak idő és csak a dátum tárolás
//Dátum esetén használható a DateTime példánya, úgy, hogy nem töltjük ki az időt.
//Ez addig jó amíg nem kell megjeleníteni
var x = new DateTime(2022, 1, 31);
Console.WriteLine(x);
//Ott vannak az idő adatok is
//Megoldás a DateOnly és a TimeOnly

var d = new DateOnly(2022, 1, 31);
Console.WriteLine(d);

var t = new TimeOnly(16, 20, 35);
Console.WriteLine(t);