using System;

namespace lp73.designPatterns.Builder
{
    public class LiassePdf : Liasse
    {
        public override void ajouteDocument(string document)
        {
            if (document.StartsWith("<PDF>"))
                contenu.Add(document);
        }

        public override void imprime()
        {
            Console.WriteLine("Liasse PDF");
            foreach (string s in contenu)
                Console.WriteLine(s);
        }
    }
}
