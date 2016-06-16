namespace lp73.designPatterns.Visitor
{
    public abstract class Societe
    {
        public string Nom { get; protected set; }
        public string Email { get; protected set; }
        public string Adresse { get; protected set; }

        protected Societe(string nom, string email, string adresse)
        {
            this.Nom = nom;
            this.Email = email;
            this.Adresse = adresse;
        }

        public abstract bool AjouteFiliale(Societe filiale);

        public abstract void AccepteVisiteur(IVisiteur visiteur);
    }
}
