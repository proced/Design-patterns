namespace lp73.designPatterns.Strategy
{
    public class Utilisateur
    {
        public static void Strategy()
        {
            VueCatalogue vueCatalogue1 = new VueCatalogue(new
                DessinTroisVehiculesLigne());
            vueCatalogue1.Dessine();
            VueCatalogue vueCatalogue2 = new VueCatalogue(new
                DessinUnVehiculeLigne());
            vueCatalogue2.Dessine();
        }
    }
}
