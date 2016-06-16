using System;

namespace lp73.designPatterns.Mediator
{
    public class ZoneSaisie : Controle
    {
        public ZoneSaisie(string nom) : base(nom){}

        public override void Saisie()
        {
            Console.WriteLine("Saisie de : " + Nom);
            Valeur = Console.ReadLine();
            this.Modifie();
        }
    }
}
