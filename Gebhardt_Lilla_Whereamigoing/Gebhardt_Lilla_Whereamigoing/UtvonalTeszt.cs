using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Legacy;


namespace Gebhardt_Lilla_Whereamigoing
{
    [TestFixture]
    internal class UtvonalTeszt
    {
        [Test]
        public void Teszt_10x10()
        {
            var mezo = FajlBeolvaso.Beolvas("palya1.txt");
            var szamolo = new UtvonalSzamolo(mezo);
            string eredmeny = szamolo.SzamolUtvonal();

            ClassicAssert.AreEqual("3 R 2 L 3 L 1 R 3 R 3 R 1 L 1 R 2 R 1 L 2 L 3 L 3 R 2 R 2 L 2 L 6 L 3 L 2 R 2 R 2 L 1 R 2 R 8 R 11 R 10 L 1", eredmeny);
        }

        [Test]
        public void Teszt_15x17()
        {
            var mezo = FajlBeolvaso.Beolvas("palya2.txt");
            var szamolo = new UtvonalSzamolo(mezo);
            string eredmeny = szamolo.SzamolUtvonal();

            ClassicAssert.AreEqual("3 R 2 L 3 L 1 R 3 R 3 R 1 L 1 R 2 R 1 L 2 L 3 L 3 R 2 R 2 L 2 L 6 L 3 L 2 R 2 R 2 L 1 R 2 R 8 R 11 R 10 L 1", eredmeny);
        }
    }
}

