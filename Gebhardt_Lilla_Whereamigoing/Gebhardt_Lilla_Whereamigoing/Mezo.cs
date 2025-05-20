using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gebhardt_Lilla_Whereamigoing
{
    public class Mezo
    {
        public char[,] Racs;
        public int Sorok;
        public int Oszlopok;

        public Mezo(int sorok, int oszlopok, string[] bemenet)
        {
            Sorok = sorok;
            Oszlopok = oszlopok;
            Racs = new char[sorok, oszlopok];

            for (int i = 0; i < sorok; i++)
            {
                for (int j = 0; j < oszlopok; j++)
                {
                    Racs[i, j] = bemenet[i][j];
                }
            }
        }

        public bool ErvenyesPozicio(int sor, int oszlop)
        {
            return sor >= 0 && sor < Sorok && oszlop >= 0 && oszlop < Oszlopok;
        }

        public char Ertek(int sor, int oszlop)
        {
            return Racs[sor, oszlop];
        }
    }

}
