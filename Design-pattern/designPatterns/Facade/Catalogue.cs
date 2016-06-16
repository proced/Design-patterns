using System.Collections.Generic;

namespace lp73.designPatterns.Facade
{
    public interface Catalogue
    {
        IList<string> retrouveVehicules(int prixMin, int
            prixMax);
    }
}
