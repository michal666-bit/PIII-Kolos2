using System;
using System.Collections.Generic;
using System.Text;

namespace MGKolokwiumPoprawa
{
    class Test
    {
        public int id { get; set; }
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public bool Powodzenie { get; set; }
        public string Nazwisko { get; set; }

        public Test (int Id,string nazwa,string opis,bool powodzenie,string nazwisko )
        {
            id = Id;
            Nazwa = nazwa;
            Opis = opis;
            Powodzenie = powodzenie;
            Nazwisko = nazwisko;
        }
        public void Deconstruct(out int Id, out bool powodzenie)
        {
            Id = id;
            powodzenie = Powodzenie;
        }
        public void Deconstruct(out string nazwa, out string opis, out string nazwisko)
        {
            nazwa = Nazwa;
            opis = Opis;
            nazwisko = Nazwisko;
        }
        public void Deconstruck(out int Id, out string nazwa, out string opis, out bool powodzenie, out string nazwisko)
        {

            Id = id;
            nazwa = Nazwa;
            opis = Opis;
            powodzenie = Powodzenie;
            nazwisko = Nazwisko;
        }
    }
}
