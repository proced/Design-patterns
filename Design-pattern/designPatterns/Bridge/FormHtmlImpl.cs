using System;

namespace lp73.designPatterns.Bridge
{
    public class FormHtmlImpl : FormulaireImpl
    {

        public void dessineTexte(string texte)
        {
            Console.WriteLine("HTML : " + texte);
        }

        public string gereZoneSaisie()
        {
            return Console.ReadLine();
        }
    }
}
