using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenia3
{
    public class KontenerNaPlyny : Kontener, IHazardNotifier
    {
        private string _rodzaj_ladunku { get; set; }
        public KontenerNaPlyny(string rodzaj_ladunku, float masa_ladunku, float wysokosc, float waga_wlasna, float glebokosc, float maksymalna_ladownosc) : base(masa_ladunku, wysokosc, waga_wlasna, glebokosc, maksymalna_ladownosc) {
            this._rodzaj_ladunku = rodzaj_ladunku;
            this._rodzaj = 'L';
            Kontener.generujNumerSeryjny(this);
        }

        public void NotifyHazard(string message, string numer_kontenera)
        {
            Console.WriteLine("Numer kontenera: " + numer_kontenera + "Wiadomosc:\n" + message);
        }
        public override void zaladujKontener(float ladunek_masa)
        {
            base.zaladujKontener(ladunek_masa);
            if (_rodzaj_ladunku.Equals("Niebezpieczny") && pojemnosc() > (0.5f * _maksymalna_ladownosc))
            {
                NotifyHazard("Próba wypelnienia niebezpiecznego ladunku powyzej 50% maksymalnej pojemnosci", _numer_seryjny);
            }else if(_rodzaj_ladunku.Equals("Bezpieczny") && pojemnosc() > (0.9f * _maksymalna_ladownosc))
            {
                NotifyHazard("Próba wypelnienia ladunku powyzej 90% maksymalnej pojemnosci", _numer_seryjny);
            }
        }

        
    }
}
