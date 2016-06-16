namespace lp73.designPatterns.PluggableFactory
{
    public abstract class Scooter
    {
        public string Modele { get; set; }
        public string Couleur { get; set; }
        protected int Puissance { get; set; }

        public Scooter Duplique()
        {
            Scooter resultat;
            resultat = (Scooter)this.MemberwiseClone();
            return resultat;
        }

        public abstract void AfficheCaracteristiques();
    }
}

