using System.Collections.Generic;

namespace lp73.designPatterns.Multicast
{
    public class MessageGeneral : MessageAbstrait
    {
        public IList<string> contenu { get; protected set; }

        public MessageGeneral(IList<string> contenu)
        {
            this.contenu = contenu;
        }
    }
}

