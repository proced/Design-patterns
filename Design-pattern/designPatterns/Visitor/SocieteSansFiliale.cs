namespace lp73.designPatterns.Visitor
{
    public class SocieteSansFiliale : Societe
    {
        public SocieteSansFiliale(string nom, string email,
            string adresse) : base(nom, email, adresse){}

        public override void AccepteVisiteur(IVisiteur visiteur)
        {
            visiteur.Visite(this);
        }

        public override bool AjouteFiliale(Societe filiale)
        {
            return false;
        }
    }
}
