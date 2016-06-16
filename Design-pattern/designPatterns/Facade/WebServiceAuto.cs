using System.Collections.Generic;

namespace lp73.designPatterns.Facade
{
    public interface WebServiceAuto
    {
        string document(int index);
        IList<string> chercheVehicules(int prixMoyen, int
            ecartMax);
    }
}
