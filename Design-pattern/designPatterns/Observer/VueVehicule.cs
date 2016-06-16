using System;

namespace lp73.designPatterns.Observer
{
    public partial class VueVehicule : Observateur
    {
        protected Vehicule Vehicule;
        protected string Texte = "";

        public VueVehicule(Vehicule vehicule)
        {
            this.Vehicule = vehicule;
            vehicule.Ajoute(this);
            MetAJourTexte();
        }

        protected void MetAJourTexte()
        {
            Texte = "Description " + Vehicule.Description + 
                    " Prix : " + Vehicule.Prix;
        }

        public void actualise()
        {
            MetAJourTexte();
            this.Redessine();
        }

        public void Redessine()
        {
            Console.WriteLine(Texte);
        }
    }
}
