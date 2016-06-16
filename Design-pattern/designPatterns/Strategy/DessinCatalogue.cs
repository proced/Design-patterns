using System.Collections.Generic;

namespace lp73.designPatterns.Strategy
{
    public interface DessinCatalogue
    {
        void dessine(IList<VueVehicule> contenu);
    }
}
