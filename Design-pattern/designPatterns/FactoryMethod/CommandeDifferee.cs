using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lp73.designPatterns.FactoryMethod
{
    class CommandeDifferee : Commande
    {
        public CommandeDifferee(double montant) : base(montant) { }

        public override void Paye()
        {
            Console.WriteLine(
                "Le paiement de la commande en differee de : " +
                Montant + " est effectué.");
        }

        public override bool Valide()
        {
            return true;
        }
    }
}
