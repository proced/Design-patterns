using System;
using System.Collections.Generic;

namespace lp73.designPatterns.Mediator
{
    public class PopupMenu : Controle
    {
        protected IList<string> options = 
            new List<string>();

        public PopupMenu(string nom) : base(nom){}

        public override void Saisie()
        {
            Console.WriteLine("Saisie de : " + Nom);
            Console.WriteLine("Valeur actuelle : " + Valeur);
            for (int index = 0; index < options.Count; index++)
                Console.WriteLine("- " + index + " )" +
                                  options[index]);
            int choix = int.Parse(Console.ReadLine());
            if ((choix >= 0) && (choix < options.Count))
            {
                bool change = (Valeur != options[choix]);
                if (change)
                {
                    Valeur = options[choix];
                    this.Modifie();
                }
            }
        }

        public void ajouteOption(string option)
        {
            options.Add(option);
        }
    }
}
