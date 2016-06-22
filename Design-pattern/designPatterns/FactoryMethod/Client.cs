using System.Collections.Generic;

namespace lp73.designPatterns.FactoryMethod
{
    public abstract class Client
    {
        protected IList<Commande> Commandes = 
            new List<Commande>();

        protected abstract Commande CreeCommande(double montant);

        public void NouvelleCommande(double montant)
        {
            Commande commande = this.CreeCommande(montant);
            if (commande.Valide())
            {
                commande.Paye();
                Commandes.Add(commande);
            }
        }
    }
}
