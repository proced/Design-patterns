namespace lp73.designPatterns.Multicast
{
    public class MessageCommercial : MessageAbstrait
    {
        public string Contenu { get; protected set; }

        public MessageCommercial(string contenu)
        {
            this.Contenu = contenu;
        }
    }
}

