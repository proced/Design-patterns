namespace lp73.designPatterns.Reflective_Visitor
{
    public interface VisiteurSociete
    {
        void visite(SocieteSansFiliale societe);
        void visite(SocieteMere societe);
    }
}
