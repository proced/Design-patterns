using System;

namespace lp73.designPatterns.Strategy
{
    public partial class VueVehicule
    {
        protected string Description;

        public VueVehicule(string description)
        {
            this.Description = description;
        }

        public void Dessine()
        {
            Console.Write(Description);
        }
    }
}
