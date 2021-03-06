﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lp73.designPatterns.AbstractFactory
{
    class AutomobileHybride : Automobile
    {
        public AutomobileHybride(string modele, string couleur,
            int puissance, double espace) : base(modele, couleur,
                puissance, espace){}

        public override void AfficheCaracteristiques()
        {
            Console.WriteLine("Automobile hybride de modèle : "
                              + Modele + " de couleur : " + Couleur + 
                              " de puissance : " + Puissance + " d'espace : " +
                              Espace);
        }
    }
}
