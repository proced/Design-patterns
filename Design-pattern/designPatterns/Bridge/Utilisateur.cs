using System;
namespace lp73.designPatterns.Bridge
{
    public class Utilisateur
    {
        public static void NouveauxFormulaires()
        {
            FormImmatriculationLuxembourg formulaire1 = new
                FormImmatriculationLuxembourg(new FormHtmlImpl());
            formulaire1.Affiche();
            if (formulaire1.GereSaisie())
                formulaire1.GenereDocument();
            Console.WriteLine();
            FormImmatriculationFrance formulaire2 = new
                FormImmatriculationFrance(new FormAppletImpl());
            formulaire2.Affiche();
            if (formulaire2.GereSaisie())
                formulaire2.GenereDocument();

            FormImmatriculationFrance formulaire3 = new FormImmatriculationFrance(new FormDocImpl());
            formulaire3.Affiche();
            if (formulaire3.GereSaisie())
                formulaire3.GenereDocument();
        }
    }
}
