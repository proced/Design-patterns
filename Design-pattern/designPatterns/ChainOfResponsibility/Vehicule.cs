namespace lp73.designPatterns.ChainOfResponsibility
{
    public class Vehicule : ObjetBase
    {
        protected string laDescription;

        public Vehicule(string description)
        {
            this.laDescription = description;
        }

        protected override string description
        {
            get
            {
                return laDescription;
            }   
        }
    }
}
