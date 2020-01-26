using System;
using System.Collections.Generic;
using System.Text;

namespace Michał_Gajewski_Kolos2
{
    class ExtensionMethod
    {
        static void main()
        {

            string nazwisko = "Kowalski";
            var sb = new StringBuilder(nazwisko);
            for (int i = 1; i < nazwisko.Length; i++) sb[i] = '*';
            Console.WriteLine(sb.ToString());

        }


    }
}
