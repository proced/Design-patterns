using System;

namespace lp73.designPatterns.Builder
{
    public class LiassePdf : Liasse
    {
        public override void AjouteDocument(string document)
        {
            if (document.StartsWith("<PDF>"))
                Contenu.Add(document);
        }

        public override void Imprime()
        {
            Console.WriteLine("Liasse PDF");
            foreach (string s in Contenu)
                Console.WriteLine(s);
        }
    }
}
