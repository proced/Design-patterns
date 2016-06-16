namespace lp73.designPatterns.State
{
    public class CommandeEnCours : EtatCommande
    {
        public CommandeEnCours(Commande commande) : base
            (commande){}

        public override void AjouteProduit(Produit produit)
        {
            Commande.Produits.Add(produit);
        }

        public override void Efface()
        {
            Commande.Produits.Clear();
        }

        public override void RetireProduit(Produit produit)
        {
            Commande.Produits.Remove(produit);
        }

        public override EtatCommande EtatSuivant()
        {
            return new CommandeValidee(Commande);
        }
    }
}
