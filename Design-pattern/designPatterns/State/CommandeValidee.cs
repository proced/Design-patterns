namespace lp73.designPatterns.State
{
    public class CommandeValidee : EtatCommande
    {
        public CommandeValidee(Commande commande) : base
            (commande){}

        public override void AjouteProduit(Produit produit){}

        public override void Efface()
        {
            Commande.Produits.Clear();
        }

        public override void RetireProduit(Produit produit){}

        public override EtatCommande EtatSuivant()
        {
            return new CommandeLivree(Commande);
        }
    }
}
