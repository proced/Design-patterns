namespace lp73.designPatterns.Singleton
{
    public class TestVendeur
    {
        public static void Singleton()
        {
            // initialisation du vendeur du système
            Vendeur leVendeur = Vendeur.Instance();
            leVendeur.Nom = "Vendeur Auto";
            leVendeur.Adresse = "Paris";
            leVendeur.Email = "vendeur@vendeur.com";
            // affichage du vendeur du système
            Affiche();
        }

        public static void Affiche()
        {
            Vendeur leVendeur = Vendeur.Instance();
            leVendeur.Affiche();
        }
    }
}
