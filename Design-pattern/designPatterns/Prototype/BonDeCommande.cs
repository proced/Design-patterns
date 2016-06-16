using System;

namespace lp73.designPatterns.Prototype
{
    public class BonDeCommande : Document
    {
        public override void Affiche()
        {
            Console.WriteLine("Affiche le bon de commande : " +
                              Contenu);
        }

        public override void Imprime()
        {
            Console.WriteLine("Imprime le bon de commande : " +
                              Contenu);
        }
    }
}
