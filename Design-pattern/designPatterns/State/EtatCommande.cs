namespace lp73.designPatterns.State
{
    public abstract class EtatCommande
    {
        protected Commande Commande;

        public EtatCommande(Commande commande)
        {
            this.Commande = commande;
        }

        public abstract void AjouteProduit(Produit produit);
        public abstract void Efface();
        public abstract void RetireProduit(Produit produit);
        public abstract EtatCommande EtatSuivant();
    }
}
