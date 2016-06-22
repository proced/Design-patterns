using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lp73.designPatterns.Prototype
{
    class Facture : Document
    {
        public override void Affiche()
        {
            Console.WriteLine(
                "Affiche la facture : " + Contenu);
        }

        public override void Imprime()
        {
            Console.WriteLine(
                "Imprime la facture : " + Contenu);
        }
    }
}
