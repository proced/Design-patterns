using System;

namespace lp73.designPatterns.Adapter
{
    public class ComposantPdf
    {
        protected string Contenu;

        public void PdfFixeContenu(string contenu)
        {
            this.Contenu = contenu;
        }

        public void PdfPrepareAffichage()
        {
            Console.WriteLine("Affichage PDF : Début");
        }

        public void PdfRafraichit()
        {
            Console.WriteLine("Affichage contenu PDF : " +
                              Contenu);
        }

        public void PdfTermineAffichage()
        {
            Console.WriteLine("Affichage PDF : Fin");
        }

        public void PdfEnvoieImprimante()
        {
            Console.WriteLine("Impression PDF : " + Contenu);
        }
    }
}
