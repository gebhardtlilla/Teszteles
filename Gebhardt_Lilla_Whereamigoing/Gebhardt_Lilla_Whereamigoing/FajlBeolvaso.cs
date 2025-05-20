using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO; // ez a File.ReadAllLines sor miatt kell  miért?
using System.Threading.Tasks;

namespace Gebhardt_Lilla_Whereamigoing
{
    internal class FajlBeolvaso
    {
        public static Mezo Beolvas(string fajlNev)
        {
            string[] sorok = File.ReadAllLines(fajlNev);
            int sorDb = int.Parse(sorok[0]);
            int oszlopDb = int.Parse(sorok[1]);

            string[] matrixSorok = new string[sorDb];
            for (int i = 0; i < sorDb; i++)
            {
                matrixSorok[i] = sorok[i + 2];
            }

            return new Mezo(sorDb, oszlopDb, matrixSorok);
        }
    }
}
