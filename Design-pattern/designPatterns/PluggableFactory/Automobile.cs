namespace lp73.designPatterns.PluggableFactory
{
    public abstract class Automobile
    {
        public string Modele { get; set; }
        public string Couleur { get; set; }
        public int Puissance { get; set; }
        public double Espace { get; set; }

        public Automobile Duplique()
        {
            Automobile resultat;
            resultat = (Automobile)this.MemberwiseClone();
            return resultat;
        }

        public abstract void AfficheCaracteristiques();
    }
}


