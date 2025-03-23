using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenia3
{
    public class KontenerNaGaz : Kontener, IHazardNotifier
    {
        private int _cisnienie {  get; set; }
        public KontenerNaGaz(int cisnienie, float masa_ladunku, float wysokosc, float waga_wlasna, float glebokosc, float maksymalna_ladownosc) : base(masa_ladunku, wysokosc, waga_wlasna, glebokosc, maksymalna_ladownosc)
        {
            this._cisnienie = cisnienie;
            this._rodzaj = 'G';
            Kontener.generujNumerSeryjny(this);
        }
        public void NotifyHazard(string message, string numer_kontenera)
        {
            Console.WriteLine("Numer kontenera: " + numer_kontenera + "Wiadomosc:\n" + message);
        }
        public override void oproznijLadunek()
        {
            _masa_ladunku *= 0.05f;
        }
        public override void zaladujKontener(float ladunek_masa)
        {
            //base.zaladujKontener(ladunek_masa);
            _masa_ladunku += ladunek_masa;
            if(_masa_ladunku > _maksymalna_ladownosc)
            {
                NotifyHazard("Przekroczono dopuszczalna ladownosc",_numer_seryjny);
                throw new Exception();
            }
        }
    }
}
