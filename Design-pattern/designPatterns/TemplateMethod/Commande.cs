using System;

namespace lp73.designPatterns.TemplateMethod
{
    public abstract class Commande
    {
        protected double MontantHt;
        protected double MontantTva;
        protected double MontantTtc;

        protected abstract void CalculeTva();

        public void CalculeMontantTtc()
        {
            this.CalculeTva();
            MontantTtc = MontantHt + MontantTva;
        }

        public void SetMontantHt(double montantHt)
        {
            this.MontantHt = montantHt;
        }

        public void Affiche()
        {
            Console.WriteLine("Commande");
            Console.WriteLine("Montant HT " + MontantHt);
            Console.WriteLine("Montant TTC " + MontantTtc);
        }
    }
}
