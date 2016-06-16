using System.Collections.Generic;

namespace lp73.designPatterns.Strategy
{
    public class VueCatalogue
    {
        protected IList<VueVehicule> Contenu = 
            new List<VueVehicule>();
        protected IDessinCatalogue Dessin;

        public VueCatalogue(IDessinCatalogue dessin)
        {
            Contenu.Add(new VueVehicule("véhicule bon marché"));
            Contenu.Add(new VueVehicule("véhicule spacieux"));
            Contenu.Add(new VueVehicule("véhicule rapide"));
            Contenu.Add(new VueVehicule("véhicule confortable"));
            Contenu.Add(new VueVehicule("véhicule sportif"));
            this.Dessin = dessin;
        }

        public void Dessine()
        {
            Dessin.Dessine(Contenu);
        }
    }
}
