using System;

namespace lp73.designPatterns.PluggableFactory
{
    public class ScooterElectricite : Scooter
    {

        public override void AfficheCaracteristiques()
        {
            Console.WriteLine("Scooter électrique de modèle : "
                              + Modele + " de couleur : " + Couleur +
                              " de puissance : " + Puissance);
        }
    }
}

