/*
Ezen szerkezet akkor hasznos, ha egy változó konstans, előre tudott értékeire 
szeretnénk reagálni megadott módon. Például, ha tudjuk, hogy egy változó értéke 
1, 2 vagy 3 lehet és nem egy 200 és 30000 közötti szám.

Ezen esetben sokkal átláthatóbb és némileg gyorsabb futást eredményez a 
programunkban a switch-case vezérlési szerkezet alkalmazása. Ezen felül tisztább 
kódot produkál, mint rengeteg if-else ág. Megadási formája:

switch ( változó )
{
	case konstans kifejezés:
		utasítás;
		break;
	default:
		utasítás;
		break;
}

A case szerkezetek végén lévő break utasítás azért kell, mert ha nem lenne ott, 
akkor a vezérlés folytatódna a következő case ágban is. Hiányáért általában
panaszkodik a fordítóprogram. Kivéve akkor, ha:

    -a switch szerkezetünk egy metódusban van és a case ág teljesülésekor return kulcsszóval visszatérünk a hívóhoz,
    -vagy kivételt dobunk a throw kulcsszó segítségével.

Az utóbbi két kivételről majd részletesebben is lesz szó később.

A default ágba a vezérlés akkor kerül, ha a fentebb megadott egyik case vezérlési 
eset sem teljesül. Megadása nem kötelező. Vezérléshez egész szám típusú változókat, 
karaktereket, szövegeket használhatunk fel, valamint felsorolást is. A felsorolás 
típusokról az összetett adatszerkezetek használatakor lesz szó.

Konzolos programok létrehozásakor a switch-case tipikusan menürendszerek készítésére használatos. 
A switch-case példa bemutatását egy rossz példával kezdeném. Az alábbi program egy egyszerű 
menürendszert jelenít meg, ahol A, B és C opciók közül választhatunk, illetve a program azt 
is helyesen lekezeli, hogy ha nem a megfelelő gombot nyomtuk le.
 */
Console.WriteLine("Menü program");
Console.WriteLine("Opciók:");
Console.WriteLine("A: Kis kávé, B: Nagy kávé");
Console.WriteLine("C: Nem iszom semmit");
Console.Write("Kérem válasszon!: ");
var gomb = (char)Console.Read();

if (gomb == 'A' || gomb == 'a')
{
    Console.WriteLine("Kis kávét választott");
}
else if (gomb == 'B' || gomb == 'b')
{
    Console.WriteLine("Nagy kávét választott");
}
else if (gomb == 'C' || gomb == 'c')
{
    Console.WriteLine("Kár");
}
else
{
    Console.WriteLine("Nem jó gombot nyomott!");
}
//Ugyanez case-el

Console.WriteLine("Menü program");
Console.WriteLine("Opciók:");
Console.WriteLine("A: Kis kávé, B: Nagy kávé");
Console.WriteLine("C: Nem iszom semmit");
Console.Write("Kérem válasszon!: ");
var gomb1 = (char)Console.Read();

switch (gomb1)
{
    case 'A':
    case 'a':
        Console.WriteLine("Kis kávét választott");
        break;
    case 'B':
    case 'b':
        Console.WriteLine("Nagy kávét választott");
        break;
    case 'C':
    case 'c':
        Console.WriteLine("Kár");
        break;
    default:
        Console.WriteLine("Nem jó gombot nyomott!");
        break;
}

/*
 A kód a sorok számának tekintetében nem lett rövidebb, azonban a lényegi rész, a vezérlés átláthatóbb, 
valamint gyorsabb is. A gyorsaság abból következik, hogy a switch utasítás egy egyszeri goto-kat 
alkalmazó utasítássá fordul le, ami alapján az ugrás gyorsabb. Jelen esetben ez a gyorsaság mondhatni 
elhanyagolható, azonban ha több száz esetet kellene megvizsgálni, akkor már jelentős különbség lehetne 
a két program működése között.
 */