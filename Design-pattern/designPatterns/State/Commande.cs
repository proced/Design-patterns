using System;
using System.Collections.Generic;

namespace lp73.designPatterns.State
{
    public class Commande
    {
        protected IList<Produit> produits = new List<Produit>();
        public IList<Produit> Produits
        {
            get
            {
                return produits;
            }
        }
        protected EtatCommande EtatCommande;

        public Commande()
        {
            EtatCommande = new CommandeEnCours(this);
        }

        public void AjouteProduit(Produit produit)
        {
            EtatCommande.AjouteProduit(produit);
        }

        public void RetireProduit(Produit produit)
        {
            EtatCommande.RetireProduit(produit);
        }

        public void Efface()
        {
            EtatCommande.Efface();
        }

        public void EtatSuivant()
        {
            EtatCommande = EtatCommande.EtatSuivant();
        }

        public void Affiche()
        {
            Console.WriteLine("Contenu de la commande");
            foreach (Produit produit in produits)
                produit.Affiche();
            Console.WriteLine();
        }
    }
}
