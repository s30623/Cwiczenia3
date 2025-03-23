using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenia3
{
    public class Kontenerowiec
    {
        public List<Kontener> _kontenery {  get; set; }
        public float _predkosc {  get; set; }
        public uint _max_ilosc_kontenerow {  get; set; }
        public float _max_waga_kontenerow { get; set; }

        public Kontenerowiec(List<Kontener> kontenery, float predkosc, uint max_ilosc_kontenerow, float max_waga_kontenerow)
        {
            _kontenery = kontenery;
            _predkosc = predkosc;
            _max_ilosc_kontenerow = max_ilosc_kontenerow;
            _max_waga_kontenerow = max_waga_kontenerow;
        }
        public Kontenerowiec(float predkosc, uint max_ilosc_kontenerow, float max_waga_kontenerow)
        {
            _kontenery = new List<Kontener>();
            _predkosc = predkosc;
            _max_ilosc_kontenerow = max_ilosc_kontenerow;
            _max_waga_kontenerow = max_waga_kontenerow;
        }
        public Kontenerowiec(Kontener kontener,float predkosc, uint max_ilosc_kontenerow, float max_waga_kontenerow)
        {
            _kontenery = new List<Kontener>() { kontener };
            _predkosc = predkosc;
            _max_ilosc_kontenerow = max_ilosc_kontenerow;
            _max_waga_kontenerow = max_waga_kontenerow;
        }

        public void zaladujKontener(Kontener kontener)
        {
            _kontenery.Add(kontener);
        }
        public void zaladujKontener(List<Kontener> kontener)
        {
            foreach (Kontener k in kontener)
            {
                zaladujKontener(k);
            }
        }
        public void rozladujKontener()
        {
            _kontenery.Clear();
        }
        public void usunKontener(string numer_seryjny)
        {
            foreach(Kontener k in _kontenery)
            {
                if (numer_seryjny.Equals(k._numer_seryjny))
                {
                    _kontenery.Remove(k);
                    break;
                }
            }
        }
        public void zastapKontener(int numer_seryjny, Kontener kontener_zastepujacy)
        {
            for(int i = 0; i < _kontenery.Count; i++)
            {
                if (_kontenery[i]._numer_seryjny.Equals(numer_seryjny))
                {
                    _kontenery[i] = kontener_zastepujacy;
                }
               
            }
        }
        public override string? ToString()
        {
            return "Kontenerowiec\nPredkosc: " + _predkosc +
                "\nMax ilosc kontenerow: " + _max_ilosc_kontenerow +
                "\nMax waga kontenerow: " + _max_waga_kontenerow + '\n';
        }
        public void przeniesPomiedzyStatkami(Kontenerowiec do_statek, string numer_seryjny)
        {
            for (int i = 0; i < _kontenery.Count; i++)
            {
                if (_kontenery[i]._numer_seryjny.Equals(numer_seryjny))
                {
                    do_statek.zaladujKontener(_kontenery[i]);
                    _kontenery.RemoveAt(i);
                    Console.WriteLine("Przeniesiono pomyslnie");
                    break;
                }

            }
        }
    }
}
