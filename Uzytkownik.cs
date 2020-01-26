using System;
using System.Collections.Generic;
using System.Text;

namespace Michał_Gajewski_Kolos2
{
    class Uzytkownik
    {

        private string Login;
        private string Haslo;
        private string dataUtworzenia;
        private int iloscPostow;
        public Uzytkownik (string Login,string Haslo,string dataUtworzenia,int iloscPostow)
        {
            this.Login = "Ala";
            this.Haslo = "Ala123";
            this.dataUtworzenia = "25.01.2020";
            this.iloscPostow = 25;
        }
    }
}
