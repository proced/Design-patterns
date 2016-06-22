using System;

namespace lp73.designPatterns.AbstractFactory
{
    public class AutomobileElectricite : Automobile
    {
        public AutomobileElectricite(string modele, string
            couleur, int puissance, double espace) : base(modele,
                couleur, puissance, espace){}

        public override void AfficheCaracteristiques()
        {
            Console.WriteLine(
                "Automobile électrique de modèle : " + Modele + 
                " de couleur : " + Couleur + " de puissance : " +
                Puissance + " d'espace : " + Espace);
        }
    }
}
