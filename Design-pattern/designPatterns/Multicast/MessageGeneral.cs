using System.Collections.Generic;

namespace lp73.designPatterns.Multicast
{
    public class MessageGeneral : MessageAbstrait
    {
        public IList<string> Contenu { get; protected set; }

        public MessageGeneral(IList<string> contenu)
        {
            this.Contenu = contenu;
        }
    }
}

