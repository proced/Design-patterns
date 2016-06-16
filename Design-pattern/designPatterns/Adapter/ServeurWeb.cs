using System;
namespace lp73.designPatterns.Adapter
{
    public class ServeurWeb
    {
        public static void NouveauxDocuments()
        {
            IDocument document1 = new DocumentHtml();
            document1.Contenu = "Hello";
            document1.Dessine();
            Console.WriteLine();
            IDocument document2 = new DocumentPdf();
            document2.Contenu = "Bonjour";
            document2.Dessine();
        }
    }
}
