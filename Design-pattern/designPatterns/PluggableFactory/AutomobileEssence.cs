﻿using System;

namespace lp73.designPatterns.PluggableFactory
{
    public class AutomobileEssence : Automobile
    {

        public override void afficheCaracteristiques()
        {
            Console.WriteLine(
                "Automobile à essence de modèle : " + modele +
                " de couleur : " + couleur + " de puissance : " +
                puissance + " d'espace : " + espace);
        }
    }
}

