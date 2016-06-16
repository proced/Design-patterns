using System;
using System.Collections.Generic;

namespace lp73.designPatterns.Strategy
{
    public class DessinUnVehiculeLigne : IDessinCatalogue
    {

        public void Dessine(IList<VueVehicule> contenu)
        {
            Console.WriteLine(
                "Dessine les véhicules avec un véhicule par ligne");
            foreach (VueVehicule vueVehicule in contenu)
            {
                vueVehicule.Dessine();
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
