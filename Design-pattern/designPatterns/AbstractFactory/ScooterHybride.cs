using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lp73.designPatterns.AbstractFactory
{
    class ScooterHybride: Scooter
    {
        public ScooterHybride(string modele, string couleur,
            int puissance) : base(modele, couleur, puissance){}

        public override void AfficheCaracteristiques()
        {
            Console.WriteLine("Scooter hybride de modèle : " +
                              Modele + " de couleur : " + Couleur + 
                              " de puissance : " + Puissance);
        }
    }
}
