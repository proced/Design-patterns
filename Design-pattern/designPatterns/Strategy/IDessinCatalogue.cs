using System.Collections.Generic;

namespace lp73.designPatterns.Strategy
{
    public interface IDessinCatalogue
    {
        void Dessine(IList<VueVehicule> contenu);
    }
}
