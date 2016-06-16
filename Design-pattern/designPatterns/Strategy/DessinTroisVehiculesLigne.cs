using System;
using System.Collections.Generic;

namespace lp73.designPatterns.Strategy
{
    public class DessinTroisVehiculesLigne : IDessinCatalogue
    {
        public void Dessine(IList<VueVehicule> contenu)
        {
            int compteur;
            Console.WriteLine(
                "Dessine les véhicules avec trois véhicules par ligne");
            compteur = 0;
            foreach (VueVehicule vueVehicule in contenu)
            {
                vueVehicule.Dessine();
                compteur++;
                if (compteur == 3)
                {
                    Console.WriteLine();
                    compteur = 0;
                }
                else
                    Console.Write(" ");
            }
            if (compteur != 0)
                Console.WriteLine();
            Console.WriteLine();
        }
    }
}
