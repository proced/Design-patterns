namespace lp73.designPatterns.FactoryMethod
{
    public abstract class Commande
    {
        protected double Montant;

        public Commande(double montant)
        {
            this.Montant = montant;
        }

        public abstract bool Valide();

        public abstract void Paye();
    }
}
