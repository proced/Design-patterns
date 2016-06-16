using System;

namespace lp73.designPatterns.State
{
    public class Produit
    {
        protected string nom;

        public Produit(string nom)
        {
            this.nom = nom;
        }

        public void affiche()
        {
            Console.WriteLine("Produit : " + nom);
        }
    }
}
