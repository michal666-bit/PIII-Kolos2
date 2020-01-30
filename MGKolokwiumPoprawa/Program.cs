using System;
using System.Collections.Generic;
using System.Linq;

namespace MGKolokwiumPoprawa
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Podaj PIN");
            int pin = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj max metraz");
            int maxMetraz = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj min metraz");
            int minMetraz = int.Parse(Console.ReadLine());

            List<Mieszkanie> mieszka = new List<Mieszkanie>();
            mieszka.Add(new Mieszkanie() { metraz = 15, nazwa = "Hotel" , OdlegloscOdCentrum = 300 });
            mieszka.Add(new Mieszkanie() { metraz = 30, nazwa = "Motel", OdlegloscOdCentrum = 21 });
            mieszka.Add(new Mieszkanie() { metraz = 12, nazwa = "Hostel", OdlegloscOdCentrum = 54 });
            mieszka.Add(new Mieszkanie() { metraz = 16, nazwa = "Dom", OdlegloscOdCentrum = 3 });
            mieszka.Add(new Mieszkanie() { metraz = 56, nazwa = "g", OdlegloscOdCentrum = 45 });
            mieszka.Add(new Mieszkanie() { metraz = 34, nazwa = "u", OdlegloscOdCentrum = 90 });
            mieszka.Add(new Mieszkanie() { metraz = 22, nazwa = "e", OdlegloscOdCentrum = 2 });
            mieszka.Add(new Mieszkanie() { metraz = 190, nazwa = "n", OdlegloscOdCentrum = 1 });
            mieszka.Add(new Mieszkanie() { metraz = 90, nazwa = "e", OdlegloscOdCentrum = 3 });
            mieszka.Add(new Mieszkanie() { metraz = 11, nazwa = "p", OdlegloscOdCentrum = 90 });
            mieszka.Add(new Mieszkanie() { metraz = 26, nazwa = "b", OdlegloscOdCentrum = 123 });
            mieszka.Add(new Mieszkanie() { metraz = 67, nazwa = "v", OdlegloscOdCentrum = 456 });
            mieszka.Add(new Mieszkanie() { metraz = 56, nazwa = "a", OdlegloscOdCentrum = 222 });

            foreach (var item in mieszka)
            {
                Console.WriteLine(item.metraz + " " + item.nazwa + " " + item.OdlegloscOdCentrum);
            }
            //mieszka.Sort();
           // foreach (Mieszkanie OdlegloscOdCentrum in mieszka)
          //  {
           //     Console.WriteLine(OdlegloscOdCentrum);
          //  }
        }
        interface IZamek
        {
            public void Otworz();
            public void Zamknij();
            class ZamekPIN : IZamek
            {
                
                public void Otworz()
                {
                    throw new NotImplementedException();
                }

                public void Zamknij()
                {
                    throw new NotImplementedException();
                }
            }
            class ZamekElektorniczny : IZamek
            {
                public void Otworz()
                {
                    throw new NotImplementedException();
                }

                public void Zamknij()
                {
                    throw new NotImplementedException();
                }
            }
        }
    }
}
