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

    }
}
