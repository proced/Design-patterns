using System;

namespace lp73.designPatterns.Prototype
{
    public class DemandeImmatriculation : Document
    {
        public override void Affiche()
        {
            Console.WriteLine(
                "Affiche la demande d'immatriculation : " + Contenu);
        }

        public override void Imprime()
        {
            Console.WriteLine(
                "Imprime la demande d'immatriculation : " + Contenu);
        }
    }
}
