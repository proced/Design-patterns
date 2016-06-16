using System;

namespace lp73.designPatterns.State
{
    public class Produit
    {
        protected string Nom;

        public Produit(string nom)
        {
            this.Nom = nom;
        }

        public void Affiche()
        {
            Console.WriteLine("Produit : " + Nom);
        }
    }
}
