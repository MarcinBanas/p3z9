using System;
using System.Collections.Generic;
using System.Text;

namespace p3z9
{
    class Kanal
    {
        public string Nazwa { get; set; }
        public int Id { get; set; }
        public int LicznikWyswietlen { get; set; }
        public int Subskrypcje = 0;

        public Kanal(string nazwa,int id,int licznikwyswietlen)
        {
            Nazwa = nazwa;
            Id = id;
            LicznikWyswietlen = licznikwyswietlen;
        }

        public void WyswietlFilm(int id)
        {
            LicznikWyswietlen++;
        }
        public event EventHandler<ZasubskrybowanoKanalEventArgs> OpublikowanoFilm;
        public void OpublikujFilm()
        {
            OpublikowanoFilm.Invoke(this, new ZasubskrybowanoKanalEventArgs());
            
        }

        
    }
}
