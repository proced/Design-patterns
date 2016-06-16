using System;

namespace lp73.designPatterns.PluggableFactory
{
    public class AutomobileElectricite : Automobile
    {

        public override void AfficheCaracteristiques()
        {
            Console.WriteLine(
                "Automobile électrique de modèle : " + Modele +
                " de couleur : " + Couleur + " de puissance : " +
                Puissance + " d'espace : " + Espace);
        }
    }
}


