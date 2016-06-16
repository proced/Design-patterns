namespace lp73.designPatterns.Reflective_Visitor
{
    public class SocieteSansFiliale : Societe
    {
        public SocieteSansFiliale(string nom, string email,
            string adresse) : base(nom, email, adresse){}

        public override bool AjouteFiliale(Societe filiale)
        {
            return false;
        }
    }
}
