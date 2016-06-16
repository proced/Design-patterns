using System;

namespace lp73.designPatterns.PluggableFactory
{
    public class AutomobileEssence : Automobile
    {

        public override void AfficheCaracteristiques()
        {
            Console.WriteLine(
                "Automobile à essence de modèle : " + Modele +
                " de couleur : " + Couleur + " de puissance : " +
                Puissance + " d'espace : " + Espace);
        }
    }
}

