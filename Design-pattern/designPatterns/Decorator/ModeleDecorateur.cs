using System;

namespace lp73.designPatterns.Decorator
{
    public class ModeleDecorateur : Decorateur
    {
        public ModeleDecorateur(ComposantGraphiqueVehicule
            composant) : base(composant){}

        protected void afficheInfosTechniques()
        {
            Console.WriteLine("Informations techniques du mod�le");
        }

        public override void affiche()
        {
            base.affiche();
            this.afficheInfosTechniques();
        }
    }
}
