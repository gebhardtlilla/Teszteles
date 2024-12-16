using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_11_28_ugyfelosztaly
{
    internal class Customer
    {
        static string firstName, lastName, birthDate, email;

        /// <summary>
        /// A számok elválasztója valószínuleg egy pont.
        /// </summary>
        public void GetAge()
        {
            string[] szuletes = birthDate.Split('.');
            int ev = Convert.ToInt32(szuletes[0]);
            int honap = Convert.ToInt32(szuletes[1]);
            int nap = Convert.ToInt32(szuletes[2]);

            int mostaniev = 2024;
            int mostanihonap = 11;
            int mostaninap = 28;

            int eletkor;
            if (mostanihonap <= honap && mostaninap <= nap)
            {
                eletkor = mostaniev - ev;
            }
            else
            {
                eletkor = mostaniev - ev - 1;
            }

        }


        public bool IsEmailValid()
        {

            string[] db = email.Split('@');
            string[] db2 = db[1].Split('.');
            if (db.Length ==2 && db2.Length ==2)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public string GetFullName()
        {     
            return firstName + " " + lastName;
        }

    }
}
