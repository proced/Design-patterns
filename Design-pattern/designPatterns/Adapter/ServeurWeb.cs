using System;
namespace lp73.designPatterns.Adapter
{
    public class ServeurWeb
    {
        public static void NouveauxDocuments()
        {
            Document document1, document2;
            document1 = new DocumentHtml();
            document1.contenu = "Hello";
            document1.dessine();
            Console.WriteLine();
            document2 = new DocumentPdf();
            document2.contenu = "Bonjour";
            document2.dessine();
        }
    }
}
