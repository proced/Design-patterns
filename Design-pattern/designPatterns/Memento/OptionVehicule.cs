using System;
using System.Collections.Generic;

namespace lp73.designPatterns.Memento
{
    public class OptionVehicule
    {
        protected string Nom;
        public IList<OptionVehicule> OptionsIncompatibles
        {get; protected set;}

        public OptionVehicule(string nom)
        {
            OptionsIncompatibles = new List<OptionVehicule>();
            this.Nom = nom;
        }

        public void AjouteOptionIncompatible(OptionVehicule
            optionIncompatible)
        {
            if (!OptionsIncompatibles.Contains(optionIncompatible))
            {
                OptionsIncompatibles.Add(optionIncompatible);
                optionIncompatible.AjouteOptionIncompatible(this);
            }
        }

        public void Affiche()
        {
            Console.WriteLine("option : " + Nom);
        }
    }
}
