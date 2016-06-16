using System;

namespace lp73.designPatterns.Bridge
{
    public class FormAppletImpl : FormulaireImpl
    {

        public void dessineTexte(string texte)
        {
            Console.WriteLine("Applet : " + texte);
        }

        public string gereZoneSaisie()
        {
            return Console.ReadLine();
        }
    }
}
