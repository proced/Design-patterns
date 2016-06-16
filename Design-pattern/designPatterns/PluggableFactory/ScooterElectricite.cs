using System;

namespace lp73.designPatterns.PluggableFactory
{
    public class ScooterElectricite : Scooter
    {

        public override void afficheCaracteristiques()
        {
            Console.WriteLine("Scooter électrique de modèle : "
                              + modele + " de couleur : " + couleur +
                              " de puissance : " + puissance);
        }
    }
}

