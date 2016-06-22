using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lp73.designPatterns.Decorator
{
    class OptionsDecorateur : Decorateur
    {
        public OptionsDecorateur(ComposantGraphiqueVehicule
            composant) : base(composant){}

        protected void afficheOptionsVehicule()
        {
            Console.WriteLine("Options du véhicule");
        }

        public override void affiche()
        {
            base.affiche();
            this.afficheOptionsVehicule();
        }
    }
}
