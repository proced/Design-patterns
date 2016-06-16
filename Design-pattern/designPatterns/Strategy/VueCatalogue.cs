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
            Contenu.Add(new VueVehicule("v�hicule bon march�"));
            Contenu.Add(new VueVehicule("v�hicule spacieux"));
            Contenu.Add(new VueVehicule("v�hicule rapide"));
            Contenu.Add(new VueVehicule("v�hicule confortable"));
            Contenu.Add(new VueVehicule("v�hicule sportif"));
            this.Dessin = dessin;
        }

        public void Dessine()
        {
            Dessin.Dessine(Contenu);
        }
    }
}
