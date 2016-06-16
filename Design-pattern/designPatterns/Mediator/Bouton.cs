using System;

namespace lp73.designPatterns.Mediator
{
    public class Bouton : Controle
    {
        public Bouton(string nom) : base(nom){}

        public override void Saisie()
        {
            Console.WriteLine("Désirez-vous activer le bouton " +
                              Nom + " ?");
            string reponse = Console.ReadLine();
            if (reponse == "oui")
                this.Modifie();
        }
    }
}
