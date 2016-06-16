namespace lp73.designPatterns.Multicast
{
    public interface IRecepteurAbstrait<in TMessage>
        where TMessage : MessageAbstrait
    {
        void Recoit(TMessage message);
    }
}

