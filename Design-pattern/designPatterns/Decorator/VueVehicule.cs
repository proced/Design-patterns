using System;

namespace lp73.designPatterns.Decorator
{
    public partial class VueVehicule : ComposantGraphiqueVehicule
    {
        public void affiche()
        {
            Console.WriteLine("Affichage du véhicule");
        }
    }
}
