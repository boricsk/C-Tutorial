/*
A do – while ciklus a sima while ciklus párja. Ez a ciklus nem a ciklusmag 
lefutása előtt nézi meg az ismétlési feltételt, hanem a ciklusmag 
végrehajtása után. Tehát egyszer mindenképpen végrehajtódik a 
ciklusmagban tárolt utasítássorozat. A szintaxisa a következő:

do
{
  //ciklusmag
}
while ( feltétel );

Tipikusan olyan esetben használjuk, mikor legalább egyszer le kell futtatnunk 
a műveletsort. Ilyen lehet például egy ellenőrzött adatbekérés a felhasználótól. 
Erre a célra kiválóan alkalmas ez a vezérlési szerkezet, mivel legalább egyszer 
be kell kérnünk az adatot és előre nem tudjuk megmondani, hogy hányszor fogja 
a bevitelt elrontani véletlenül a felhasználó. Az alábbi példa ennek az 
alkalmazását mutatja be:
*/
namespace _017_do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            do_while();
            deMorgan();
        }

        static void do_while()
        {
            int szam = -1;
            do
            {
                try
                {
                    Console.WriteLine("Kérek egy páros számot 1-10 között. ");
                    string user_input = Console.ReadLine();
                    szam = Convert.ToInt32(user_input);
                }
                catch (Exception)
                {
                    szam = -1;
                }
                //A ciklusban maradás feltételét kell megadni, nem pedig kilépési feltételt
                //A de Morgan azonosságok szerint egy összetett logikai feltétel tagadásakor
                //nem csak az egyes feltételeket kell tadadni, hanem a köztük lévő műveletet is.
                //Példa
                // if ((x > 10) && ((x % 3) == 0)) darab++;
                // if ((x < 10) || ((x % 3) != 0)) darab++;

            } while ((szam < 0) || (szam > 10) || (szam % 2 != 0));

            Console.WriteLine($"A megadott szám : {szam}");
        }

        static void deMorgan()
        {
            int x = 0;
            int darab = 0;

            for (x = 0; x < 10; x++)
            {
                if ((x > 10) && ((x % 3) == 0)) { darab++; }
            }
            Console.WriteLine($"if ((x > 10) && ((x % 3) == 0)) -> {darab}");

            x = 0;
            darab = 0;

            for (x = 0; x < 10; x++)
            {
                if ((x < 10) || ((x % 3) != 0)) { darab++; }
            }
            Console.WriteLine($"if ((x < 10) || ((x % 3) != 0)) -> {darab}");
        }
    }
}
