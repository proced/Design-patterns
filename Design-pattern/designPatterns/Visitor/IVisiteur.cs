namespace lp73.designPatterns.Visitor
{
    public interface IVisiteur
    {
        void Visite(SocieteSansFiliale societe);
        void Visite(SocieteMere societe);
    }
}
