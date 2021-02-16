using System;
using System.Collections;

namespace p3z9
{
    class Program
    {
        static void Main(string[] args)
        {
            var uzytkownik1 = new Uzytkownik();
            var uzytkownik2 = new Uzytkownik();
            var uzytkownik3 = new Uzytkownik();
            var uzytkownik4 = new Uzytkownik();
            var kanal = new Kanal("P3",1,0);

            ArrayList Lista = new ArrayList();

            Lista.Add(uzytkownik1);
            Lista.Add(uzytkownik2);
            Lista.Add(uzytkownik3);
            Lista.Add(uzytkownik4);

            foreach (Uzytkownik i in Lista)
            {
                i.SubskrubujKanal(kanal);
            }

            
            kanal.OpublikujFilm();
            kanal.Wyswietl();
            
            
        }
    }
}
