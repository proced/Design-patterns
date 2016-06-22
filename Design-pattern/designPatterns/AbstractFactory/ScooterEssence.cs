using System;

namespace lp73.designPatterns.AbstractFactory
{
    public class ScooterEssence : Scooter
    {
        public ScooterEssence(string modele, string couleur,
            int puissance) : base(modele, couleur, puissance){}

        public override void AfficheCaracteristiques()
        {
            Console.WriteLine("Scooter � essence de mod�le : " +
                              Modele + " de couleur : " + Couleur + 
                              " de puissance : " + Puissance);
        }

    }
}
