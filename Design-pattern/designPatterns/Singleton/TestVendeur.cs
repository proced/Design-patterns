namespace lp73.designPatterns.Singleton
{
    public class TestVendeur
    {
        public static void Singleton()
        {
            // initialisation du vendeur du syst�me
            Vendeur leVendeur = Vendeur.Instance();
            leVendeur.Nom = "Vendeur Auto";
            leVendeur.Adresse = "Paris";
            leVendeur.Email = "vendeur@vendeur.com";
            // initialisation du comptable du syst�me
            Comptable leComptable = Comptable.Instance();
            leComptable.Nom = "Comptable Jack";
            leComptable.Adresse = "Strasbourg";
            leComptable.Email = "comptable@comptable.com";
            // affichage du vendeur et du comptable du syst�me
            Affiche();
        }

        public static void Affiche()
        {
            Vendeur leVendeur = Vendeur.Instance();
            leVendeur.Affiche();
            Comptable leComptable = Comptable.Instance();
            leComptable.Affiche();
        }
    }
}
