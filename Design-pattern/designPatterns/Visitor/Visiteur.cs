namespace lp73.designPatterns.Visitor
{
    public interface Visiteur
    {
        void visite(SocieteSansFiliale societe);
        void visite(SocieteMere societe);
    }
}
