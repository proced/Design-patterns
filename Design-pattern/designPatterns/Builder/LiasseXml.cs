using System;

namespace lp73.designPatterns.Builder
{
    public class LiasseXml : Liasse
    {
        public override void AjouteDocument(string document)
        {
            if (document.StartsWith("<XML>"))
                Contenu.Add(document);
        }

        public override void Imprime()
        {
            Console.WriteLine("Liasse XML");
            foreach (string s in Contenu)
                Console.WriteLine(s);
        }
    }
}
