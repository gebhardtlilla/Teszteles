using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gebhardt_Lilla_Whereamigoing
{
    public class UtvonalSzamolo
    {
        private Mezo mezo;
        private int sor, oszlop;
        private int irany; // 0 = jobbra, 1 = le, 2 = balra, 3 = fel

        private int[] sorValtozas = { 0, 1, 0, -1 };
        private int[] oszlopValtozas = { 1, 0, -1, 0 };

        public UtvonalSzamolo(Mezo mezo)
        {
            this.mezo = mezo;
            sor = 0;
            oszlop = 0;
            irany = 0;
        }

        public string SzamolUtvonal()
        {
            // Belépés a pályára: keressük az első '#' karaktert az első sorban
            while (!mezo.ErvenyesPozicio(sor, oszlop) || mezo.Ertek(sor, oszlop) != '#')
            {
                oszlop++;
            }

            StringBuilder eredmeny = new StringBuilder();
            int lepesek = 0;

            while (true)
            {
                int kovetkezoSor = sor + sorValtozas[irany];
                int kovetkezoOszlop = oszlop + oszlopValtozas[irany];

                if (mezo.ErvenyesPozicio(kovetkezoSor, kovetkezoOszlop) &&
                    mezo.Ertek(kovetkezoSor, kovetkezoOszlop) == '#')
                {
                    sor = kovetkezoSor;
                    oszlop = kovetkezoOszlop;
                    lepesek++;
                }
                else
                {
                    eredmeny.Append(lepesek);
                    lepesek = 0;

                    if (VanUt('R'))
                    {
                        eredmeny.Append("R");
                        irany = (irany + 1) % 4;
                    }
                    else if (VanUt('L'))
                    {
                        eredmeny.Append("L");
                        irany = (irany + 3) % 4;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return eredmeny.ToString().Trim();
        }

        private bool VanUt(char iranyBetu)
        {
            int ujIrany = iranyBetu == 'R' ? (irany + 1) % 4 : (irany + 3) % 4;
            int ujSor = sor + sorValtozas[ujIrany];
            int ujOszlop = oszlop + oszlopValtozas[ujIrany];
            return mezo.ErvenyesPozicio(ujSor, ujOszlop) && mezo.Ertek(ujSor, ujOszlop) == '#';
        }
    }
}
