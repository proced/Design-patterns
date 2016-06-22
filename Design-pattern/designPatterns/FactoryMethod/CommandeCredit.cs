using System;

namespace lp73.designPatterns.FactoryMethod
{
    public class CommandeCredit : Commande
    {
        public CommandeCredit(double montant) : base(montant){}

        public override void Paye()
        {
            Console.WriteLine(
                "Le paiement de la commande au cr�dit de : " +
                Montant + " est effectu�.");
        }

        public override bool Valide()
        {
            return (Montant >= 1000.0) && (Montant <= 5000.0);
        }
    }
}
