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
        private ICollection<Produkt> _produkty {  get; set; }
        public KontenerChlodniczy(string rodzaj_produktu, float masa_ladunku, float wysokosc, float waga_wlasna, float glebokosc, float maksymalna_ladownosc) : base(masa_ladunku, wysokosc, waga_wlasna, glebokosc, maksymalna_ladownosc)
        {
            this._rodzaj_produktu = rodzaj_produktu;
            this._rodzaj = 'C';
            Kontener.generujNumerSeryjny(this);
        }
        public void oproznijLadunek()
        {
            base.oproznijLadunek();
            _produkty.Clear();
        }
        public virtual void zaladujKontener(Produkt produkt)
        {
            if (produkt._nazwa_produktu.Equals(this._rodzaj_produktu))
            {
                if(_temperatura_kontenera < produkt._temperatura_wymagana)
                {
                    throw new Exception("Za niska temperatura kontenera");
                }
                _masa_ladunku += produkt._masa;
                if (_masa_ladunku > _maksymalna_ladownosc)
                {
                    throw new OverfillException();
                }
            }
            
        }

    }
}
