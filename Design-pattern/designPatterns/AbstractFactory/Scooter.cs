namespace lp73.designPatterns.AbstractFactory
{
    public abstract class Scooter
    {
        protected string Modele;
        protected string Couleur;
        protected int Puissance;

        public Scooter(string modele, string couleur, int
            puissance)
        {
            this.Modele = modele;
            this.Couleur = couleur;
            this.Puissance = puissance;
        }
        public abstract void AfficheCaracteristiques();
    }
}
