using System;

namespace lp73.designPatterns.Bridge
{
    public class FormAppletImpl : IFormulaireImpl
    {

        public void DessineTexte(string texte)
        {
            Console.WriteLine("Applet : " + texte);
        }

        public string GereZoneSaisie()
        {
            return Console.ReadLine();
        }
    }
}
