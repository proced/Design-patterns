using System;

namespace lp73.designPatterns.PluggableFactory
{
    public class ScooterEssence : Scooter
    {

        public override void afficheCaracteristiques()
        {
            Console.WriteLine("Scooter à essence de modèle : " +
                              modele + " de couleur : " + couleur +
                              " de puissance : " + puissance);
        }
    }
}


