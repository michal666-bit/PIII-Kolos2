using System;
using System.Collections.Generic;
using System.Linq;


namespace Michał_Gajewski_Kolos2
{
    class Post
    {
        public string Tytul { get; private set; }
        public string Autor { get; private set; }
        public string Tresc { get; private set; }
        public int DataDodania { get; private set; }
        public Post(string tTytul, string aAutor, string tTresc, int dDataDodania)
        {
            Tytul = tTytul;
            Autor = aAutor;
            Tresc = tTresc;
            DataDodania = dDataDodania;
        }


        class Program
        {
            static void Main(string[] args)
            {
                List<int> lista = Enumerable.Range(150, 100)
               .Select(x => (int)x).ToList();


                var stringi = GenerycznaMetoda<string>("napis");
                var stringi1 = GenerycznaMetoda<string>("napis2");
                Console.WriteLine("Metoda z parametrem string: " + stringi + stringi1 );

                Console.ReadKey();
            }

            public static T GenerycznaMetoda<T>(T parametr)
            {
                return parametr;
            }





        }
    } 
}
    

