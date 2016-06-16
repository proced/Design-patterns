using System;

namespace lp73.designPatterns.Iterator
{
    public class Vehicule : Element
    {

        public Vehicule(string description) : base(description){}

        public void Affiche()
        {
            Console.WriteLine("Description du véhicule : " +
                              Description);
        }
    }
}
