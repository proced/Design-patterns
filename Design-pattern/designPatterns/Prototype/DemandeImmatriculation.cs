using System;

namespace lp73.designPatterns.Prototype
{
    public class DemandeImmatriculation : Document
    {
        public override void affiche()
        {
            Console.WriteLine(
                "Affiche la demande d'immatriculation : " + contenu);
        }

        public override void imprime()
        {
            Console.WriteLine(
                "Imprime la demande d'immatriculation : " + contenu);
        }
    }
}
