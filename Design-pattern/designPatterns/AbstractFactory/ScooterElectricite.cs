using System;

namespace lp73.designPatterns.AbstractFactory
{
    public class ScooterElectricite : Scooter
    {
        public ScooterElectricite(string modele, string couleur,
            int puissance) : base(modele, couleur, puissance){}

        public override void AfficheCaracteristiques()
        {
            Console.WriteLine("Scooter �lectrique de mod�le : " +
                              Modele + " de couleur : " + Couleur + 
                              " de puissance : " + Puissance);
        }

    }
}
