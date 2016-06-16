using System;

namespace lp73.designPatterns.PluggableFactory
{
    public class ScooterEssence : Scooter
    {

        public override void AfficheCaracteristiques()
        {
            Console.WriteLine("Scooter à essence de modèle : " +
                              Modele + " de couleur : " + Couleur +
                              " de puissance : " + Puissance);
        }
    }
}


