namespace lp73.designPatterns.Reflective_Visitor
{
    public abstract class Societe : IVisitable
    {
        public string Nom { get; protected set; }
        public string Email { get; protected set; }
        public string Adresse { get; protected set; }

        public Societe(string nom, string email, string adresse)
        {
            this.Nom = nom;
            this.Email = email;
            this.Adresse = adresse;
        }

        public abstract bool AjouteFiliale(Societe filiale);
    }
}
