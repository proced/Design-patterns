namespace lp73.designPatterns.Reflective_Visitor
{
    public interface IVisiteurSociete
    {
        void Visite(SocieteSansFiliale societe);
        void Visite(SocieteMere societe);
    }
}
