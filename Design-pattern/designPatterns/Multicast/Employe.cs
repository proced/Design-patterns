using System;

namespace lp73.designPatterns.Multicast
{
    public abstract class Employe : IRecepteurGeneral
    {
        protected string Nom;

        protected Employe(string nom)
        {
            this.Nom = nom;
        }

        public void Recoit(MessageGeneral message)
        {
            Console.WriteLine("Message général");
            Console.WriteLine("Nom : " + Nom);
            Console.WriteLine("Message : ");
            foreach (string ligne in message.Contenu)
                Console.WriteLine(ligne);
        }
    }
}

