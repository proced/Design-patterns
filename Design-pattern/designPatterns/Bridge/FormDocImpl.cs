using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lp73.designPatterns.Bridge
{
    class FormDocImpl  : IFormulaireImpl
    {

        public void DessineTexte(string texte)
        {
            Console.WriteLine("DOC : " + texte);
        }

        public string GereZoneSaisie()
        {
            return Console.ReadLine();
        }
    }
}
