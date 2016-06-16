using System.Collections.Generic;

namespace lp73.designPatterns.Multicast
{
    public abstract class ExpediteurAbstrait
        <TMessage, TRecepteur>
        where TMessage : MessageAbstrait
        where TRecepteur : IRecepteurAbstrait<TMessage>
    {
        protected IList<TRecepteur> Registre =
            new List<TRecepteur>();

        public void Ajoute(TRecepteur recepteur)
        {
            Registre.Add(recepteur);
        }

        public void EnvoieMultiple(TMessage message)
        {
            foreach (TRecepteur recepteur in Registre)
                recepteur.Recoit(message);
        }
    }
}

