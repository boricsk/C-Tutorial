/*
 while (feltétel)
{
    Ciklusmag;
}
Előltesztelős, azaz a futás elején értékelődik ki a feltétel, tehát nem biztos hogy a mag végre lesz hajtva.
A hátultesztelős esetén a mag 1x lehalább le fog futni.
 */
using System;

namespace PeldaWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //while_1(100);
            while_2();

        }

        static void while_1(int i)
        {
            int j = 0;
            while (j < i)
            {
                Console.Write(j);
                j++;
            }
        }
        
        //"goes to" vagy "goes torwards to" operátor
        static void while_2()
        {
            int i = 10;
            while (i-- > 0)
            {
                Console.Write(i);                
            }
        }

    }
}
