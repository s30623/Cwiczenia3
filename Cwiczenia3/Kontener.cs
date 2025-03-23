using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenia3
{
    public class Kontener
    {
        public Kontener(float masa_ladunku, float wysokosc, float waga_wlasna, float glebokosc, float maksymalna_ladownosc)
        {
            _masa_ladunku = masa_ladunku;
            _wysokosc = wysokosc;
            _waga_wlasna = waga_wlasna;
            _glebokosc = glebokosc;
            
            _maksymalna_ladownosc = maksymalna_ladownosc;
            generujNumerSeryjny(this);
        }
        public static int ilosc_C { get; set; } = 0;
        public static int ilosc_G { get; set; } = 0;
        public static int ilosc_L { get; set; } = 0;
        public char _rodzaj {  get; set; }
        public float _masa_ladunku { get; set; }
        public float _wysokosc {  get; set; }
        public float _waga_wlasna {  get; set; }
        public float _glebokosc {  get; set; }
        public string? _numer_seryjny {  get; set; }
        public float _maksymalna_ladownosc {  get; set; }

        public virtual void oproznijLadunek()
        {
            _masa_ladunku = 0;
        }
        public virtual void zaladujKontener(float ladunek_masa)
        {
            _masa_ladunku += ladunek_masa;
            if(_masa_ladunku > _maksymalna_ladownosc)
            {
                throw new OverfillException();
            }
        }
        public float pojemnosc()
        {
            return _wysokosc*_glebokosc*_masa_ladunku;
        }
        public static void generujNumerSeryjny(Kontener kontener)
        {
            string numer_seryjny = "KON";
            switch (kontener._rodzaj)
            {
                case 'C':
                    numer_seryjny += "-C-";
                    numer_seryjny += ilosc_C++;
                    
                    break;
                case 'L':
                    numer_seryjny += "-L-";
                    numer_seryjny += ilosc_L++;
                    break;
                case 'G':
                    numer_seryjny += "-G-";
                    numer_seryjny += ilosc_G++;
                    break;
            }
            kontener._numer_seryjny = numer_seryjny;
        }
        

    }
}
