using System;

namespace lp73.designPatterns.Bridge
{
    public class FormHtmlImpl : IFormulaireImpl
    {

        public void DessineTexte(string texte)
        {
            Console.WriteLine("HTML : " + texte);
        }

        public string GereZoneSaisie()
        {
            return Console.ReadLine();
        }
    }
}
