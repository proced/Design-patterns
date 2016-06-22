using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lp73.designPatterns.Singleton
{
    class Comptable
   {
        public string Nom { get; set; }
        public string Adresse { get; set; }
        public string Email { get; set; }

        private static Comptable _instance = null;

        private Comptable() { }

        public static Comptable Instance()
        {
            if (_instance == null)
                _instance = new Comptable();
            return _instance;
        }

        public void Affiche()
        {
            Console.WriteLine("Nom : " + Nom);
            Console.WriteLine("Adresse : " + Adresse);
            Console.WriteLine("Email : " + Email);
            Console.WriteLine("Poste : Comtable");
        }

    }
}
