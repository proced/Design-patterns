using System;
using System.Collections.Generic;

namespace lp73.designPatterns.Strategy
{
    public class DessinUnVehiculeLigne : DessinCatalogue
    {

        public void dessine(IList<VueVehicule> contenu)
        {
            Console.WriteLine(
                "Dessine les véhicules avec un véhicule par ligne");
            foreach (VueVehicule vueVehicule in contenu)
            {
                vueVehicule.dessine();
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
