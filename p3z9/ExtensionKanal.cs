using System;
using System.Collections.Generic;
using System.Text;

namespace p3z9
{
    static class ExtensionKanal
    {
        public static void Wyswietl(this Kanal kanal)
        {
            Console.WriteLine("Nazwa kanalu:"+kanal.Nazwa+" Ilosc subskrypcji:"+kanal.Subskrypcje+" Ilosc wyswietlen:"+kanal.LicznikWyswietlen);
        }
    }
}
