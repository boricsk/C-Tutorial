/*
A foreach ciklus egy speciális ciklus, amelyet direkt listák, tömbök és 
minden olyan osztály elemeinek bejárására találtak ki, amelyek 
megvalósítják az IEnumerable interfészt.

foreach (var valtozo in lista)
{
  //ciklusmag
}

A ciklus annyiszor fog lefutni, ahány elemű a lista. A valtozo nevű 
ciklusváltozó pedig minden egyes ciklus futáskor a lista, vagy 
IEnumerable leszármazott aktuális elemét tárolja.

A ciklus működését talán egy példán keresztül könnyebb megérteni. 
Az alábbi példában az angol ABC betűit írjuk ki:

*/

namespace _018_foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            foreach_demo();
        }

        static void foreach_demo()
        {
            var abc = "abcdefghijklmnopqrstuvwxyz";
            foreach (var betu in abc)
            {
                Console.Write("{0}, ", betu);
            }            
        }
        /*
         A trükk a programban az, hogy a szükséges betűk szövegként vannak tárolva, 
        ami végül is karakterek tömbje, ezért működik a foreach ciklus. 
        Ajánlott kódolási konvenció1, hogy a bejárt objektum neve többesszámot 
        fejezzen ki, míg a ciklus változó egyes számban legyen. 
        Ez főként angol nyelven írt programoknál hasznos, mivel drámaian 
        javítja a kód olvashatóságát. Példa:

            foreach (var letter in letters)
            {
              //utasítások
            }
        */

    }
}
