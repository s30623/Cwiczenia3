// See https://aka.ms/new-console-template for more information
using Cwiczenia3;

Console.WriteLine("Hello, World!");
KontenerChlodniczy kontener = new KontenerChlodniczy("Jablko",1, 1, 1, 1, 1);
KontenerChlodniczy kontener2 = new KontenerChlodniczy("Jablko", 1, 1, 1, 1, 1);
KontenerChlodniczy kontener3 = new KontenerChlodniczy("Jablko", 1, 1, 1, 1, 1);
KontenerNaPlyny kontener4 = new KontenerNaPlyny("Bezpieczny", 1, 1, 1, 1, 1);
KontenerChlodniczy kontener5 = new KontenerChlodniczy("Jablko", 1, 1, 1, 1, 1);
KontenerNaGaz kontener6 = new KontenerNaGaz(1,1,1,1,1,1);
Console.WriteLine(kontener4._numer_seryjny);
Console.WriteLine(kontener3);
Console.WriteLine(kontener6);
Kontenerowiec kontenerowiec = new Kontenerowiec(12,300,5);
kontenerowiec.zaladujKontener(new List<Kontener>() { kontener, kontener2, kontener3, kontener4, kontener5 });
Console.WriteLine(kontenerowiec);
Console.WriteLine(kontenerowiec._kontenery);
foreach(Kontener k in kontenerowiec._kontenery)
{
    Console.WriteLine(k);
}