using System;

namespace lp73.designPatterns.Multicast
{
    public class Commercial : Employe, IRecepteurCommercial
    {
        public Commercial(string nom)
            : base(nom)
        {
        }

        public void Recoit(MessageCommercial message)
        {
            Console.WriteLine("Message commercial");
            Console.WriteLine("Nom : " + Nom);
            Console.WriteLine("Message : " +
                              message.Contenu);
        }
    }
}


