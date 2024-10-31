namespace _019_break_continue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Break példa");
            for (int i = 0; i < 100; i++) 
            {
                if (i == 30) { Console.WriteLine($"i = 30 nál kiugrott a ciklusból. i = {i}");  break; }
            }
            Console.WriteLine();
            Console.WriteLine("Continue példa (Csak a 3-al osztható számok listája)");
            for (int i = 100; i >= 0; i--) 
            {
                if (i % 3 == 0) { Console.Write($"{i} "); continue; }
                //Ha a szám osztható 3-al akkor kiirja a számot és visszaugrik a vezérlés a ciklusra
                //ami új iterációt kezd. Ha lenne uti az if után az nem hajtódna végre
            }
        }
    }
}
