/*
 A checked kód blokk belsejében elhelyezett egész számokon végzett műveletek 
OverflowException típusú kivételt váltanak ki túlcsordulás esetén, amit ha 
nem kezelünk le kivételkezeléssel (lásd később), akkor a programunk összeomlik.

Lehetőségünk van unchecked kód blokkban ezen ellenőrzés kikapcsolására. 
Az unchecked kód blokkban történő műveletvégzés esetén a számok simán 
túlcsordulhatnak fordítási és futási időben is a típus által meghatározott 
maximum értéken.

Az alábbi kódrészlet a Checked és Unchecked kontextus használatát mutatja be:
 */
unchecked
{
    //nem okoz problémát, mert unchecked blokk
    int ertek = int.MaxValue + 100;
    checked
    {
        try
        {
            //mivel checked blokkban vagyunk kivétel
            //fog keletkezni
            int ertek2 = int.MaxValue;
            ertek2 *= 2;
        }
        catch (OverflowException)
        {
            Console.WriteLine("Tulcsordult");
        }
    }
    Console.WriteLine(ertek);
}
//Ha checked-re módosítod rögtön jelzi a hibaüzenetet.