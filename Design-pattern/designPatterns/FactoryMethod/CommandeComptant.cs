using System;

namespace lp73.designPatterns.FactoryMethod
{
    public class CommandeComptant : Commande
    {
        public CommandeComptant(double montant) : base(montant){}

        public override void Paye()
        {
            Console.WriteLine(
                "Le paiement de la commande au comptant de : " +
                Montant + " est effectué.");
        }

        public override bool Valide()
        {
            return true;
        }
    }
}
