using System;
using System.Collections.Generic;
using System.Text;

namespace p3z9
{
    class Uzytkownik
    {
        public string Nazwa { get; set; }
        public int Id { get; set; }

        public void Uzytkownik_OpublikowanoFilm(object sender, EventArgs e)
        {
            Console.WriteLine("użytkownik  otrzymał powiadomienie o nowym filmie");
        }
        public void SubskrubujKanal(Kanal obj)
        {
            obj.OpublikowanoFilm += this.Uzytkownik_OpublikowanoFilm;
            obj.Subskrypcje++;

        }
    }
}
