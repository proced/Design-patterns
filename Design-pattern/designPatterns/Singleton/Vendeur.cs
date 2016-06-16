using System;

namespace lp73.designPatterns.Singleton
{
    public class Vendeur
    {
        public string Nom { get; set; }
        public string Adresse { get; set; }
        public string Email { get; set; }

        private static Vendeur _instance = null;

        private Vendeur(){}

        public static Vendeur Instance()
        {
            if (_instance == null)
                _instance = new Vendeur();
            return _instance;
        }

        public void Affiche()
        {
            Console.WriteLine("Nom : " + Nom);
            Console.WriteLine("Adresse : " + Adresse);
            Console.WriteLine("Email : " + Email);
        }

    }
}
