namespace lp73.designPatterns.Iterator
{
    public class Utilisateur
    {
        public static void Iterator(string recherche)
        {
            CatalogueVehicule catalogue = new CatalogueVehicule();
            IterateurVehicule iterateur = catalogue.Recherche(
                recherche);
            iterateur.Debut();
            var vehicule = iterateur.Item();
            while (vehicule != null)
            {
                vehicule.Affiche();
                iterateur.Suivant();
                vehicule = iterateur.Item();
            }
        }
    }
}
