using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025_01_09_TovabbinUnittesztek
{
    internal class AdatOsztaly
    {
        public int OsszegzestolNig(int n)
        {
            int sum = 0;
            for(int i = 1; i <= n; i++)
            {
                sum += i;
            }

            return sum;
        }

        /*A szöveg hossza [1,255]*/
        public bool IsValidString(string input)
        {
            if(input == null) return false;
            if(input.Length>0 || input.Length<256)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
