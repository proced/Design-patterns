using System;

namespace lp73.designPatterns.Adapter
{
    public class DocumentXml: IDocument
    {
        public string Contenu { get; set; }

        public void Dessine()
        {
            Console.WriteLine("Dessine document XML : " +
                              Contenu);
        }

        public void Imprime()
        {
            Console.WriteLine("Imprime document XML : " +
                              Contenu);
        }

    }
}
