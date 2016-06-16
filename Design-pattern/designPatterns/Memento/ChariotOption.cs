using System;
using System.Collections.Generic;

namespace lp73.designPatterns.Memento
{
    public class ChariotOption
    {
        protected IList<OptionVehicule> Options = 
            new List<OptionVehicule>();

        public IMemento AjouteOption(OptionVehicule
            optionVehicule)
        {
            MementoImpl resultat = new MementoImpl();
            resultat.Etat = Options;
            IList<OptionVehicule> optionsIncompatibles =
                optionVehicule.OptionsIncompatibles;
            foreach (OptionVehicule option in
                optionsIncompatibles)
                Options.Remove(option);
            Options.Add(optionVehicule);
            return resultat;
        }

        public void Annule(IMemento memento)
        {
            MementoImpl mementoImplInstance = memento as MementoImpl;
            if (mementoImplInstance == null)
                return;
            Options = mementoImplInstance.Etat;
        }

        public void Affiche()
        {
            Console.WriteLine("Contenu du chariot des options");
            foreach (OptionVehicule option in Options)
                option.Affiche();
            Console.WriteLine();
        }
    }
}
