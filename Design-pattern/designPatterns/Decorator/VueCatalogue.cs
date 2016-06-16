namespace lp73.designPatterns.Decorator
{
    public class VueCatalogue
    {
        public static void VueVehicule()
        {
            VueVehicule vueVehicule = new VueVehicule();
            ModeleDecorateur modeleDecorateur = new ModeleDecorateur((ComposantGraphiqueVehicule)vueVehicule);
            MarqueDecorateur marqueDecorateur = new
                MarqueDecorateur(modeleDecorateur);
            marqueDecorateur.affiche();
        }
    }
}
