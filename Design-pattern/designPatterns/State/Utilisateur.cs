namespace lp73.designPatterns.State
{
    public class Utilisateur
    {
        public static void State()
        {
            Commande commande = new Commande();
            commande.AjouteProduit(new Produit("véhicule 1"));
            commande.AjouteProduit(new Produit("Accessoire 2"));
            commande.Affiche();
            commande.EtatSuivant();
            commande.AjouteProduit(new Produit("Accessoire 3"));
            commande.Efface();
            commande.Affiche();

            Commande commande2 = new Commande();
            commande2.AjouteProduit(new Produit("véhicule 11"));
            commande2.AjouteProduit(new Produit("Accessoire 21"));
            commande2.Affiche();
            commande2.EtatSuivant();
            commande2.Affiche();
            commande2.EtatSuivant();
            commande2.Efface();
            commande2.Affiche();
        }
    }
}
