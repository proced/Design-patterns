namespace lp73.designPatterns.AbstractFactory
{
    public abstract class Automobile
    {
        protected string Modele;
        protected string Couleur;
        protected int Puissance;
        protected double Espace;

        protected Automobile(string modele, string couleur, int
            puissance, double espace)
        {
            this.Modele = modele;
            this.Couleur = couleur;
            this.Puissance = puissance;
            this.Espace = espace;
        }

        public abstract void AfficheCaracteristiques();
    }
}
