using System;

namespace lp73.designPatterns.Builder
{
    public class LiasseHtml : Liasse
    {
        public override void AjouteDocument(string document)
        {
            if (document.StartsWith("<HTML>"))
                Contenu.Add(document);
        }

        public override void Imprime()
        {
            Console.WriteLine("Liasse HTML");
            foreach (string s in Contenu)
                Console.WriteLine(s);
        }
    }
}
