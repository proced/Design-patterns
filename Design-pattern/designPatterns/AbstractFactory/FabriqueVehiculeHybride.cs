using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lp73.designPatterns.AbstractFactory
{
    class FabriqueVehiculeHybride : IFabriqueVehicule
    {
        public Automobile CreeAutomobile(string modele, string
            couleur, int puissance, double espace)
        {
            return new AutomobileHybride(modele, couleur,
                puissance, espace);
        }

        public Scooter CreeScooter(string modele, string
            couleur, int puissance)
        {
            return new ScooterHybride(modele, couleur, puissance);
        }
    }
}
