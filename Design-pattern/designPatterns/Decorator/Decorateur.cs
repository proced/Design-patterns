namespace lp73.designPatterns.Decorator
{
    public abstract class Decorateur :
        ComposantGraphiqueVehicule
    {
        protected ComposantGraphiqueVehicule composant;

        public Decorateur(ComposantGraphiqueVehicule composant)
        {
            this.composant = composant;
        }

        public virtual void affiche()
        {
            composant.affiche();
        }
    }
}
