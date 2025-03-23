using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenia3
{
    public class KontenerChlodniczy : Kontener
    {
        public string _rodzaj_produktu {  get; set; }
        private float _temperatura_kontenera {  get; set; }
        private List<string> _produkty {  get; set; }
        public KontenerChlodniczy(float masa_ladunku, float wysokosc, float waga_wlasna, float glebokosc, float maksymalna_ladownosc) : base(masa_ladunku, wysokosc, waga_wlasna, glebokosc, maksymalna_ladownosc)
        {
            this._rodzaj = 'C';
            Kontener.generujNumerSeryjny(this);
        }

    }
}
