using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gebhardt_Lilla_Whereamigoing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*https://www.codingame.com/training/easy/where-am-i-going */
            int sorok = int.Parse(Console.ReadLine());
            int oszlopok = int.Parse(Console.ReadLine());

            string[] terkep = new string[sorok];
            for (int i = 0; i < sorok; i++)
            {
                terkep[i] = Console.ReadLine();
            }

            Mezo mezo = new Mezo(sorok, oszlopok, terkep);
            UtvonalSzamolo szamolo = new UtvonalSzamolo(mezo);
            Console.WriteLine(szamolo.SzamolUtvonal());

        } 
    }
}
