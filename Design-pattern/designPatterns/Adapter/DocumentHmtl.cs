using System;

namespace lp73.designPatterns.Adapter
{
    public class DocumentHtml : IDocument
    {
        public string Contenu { get; set; }

        public void Dessine()
        {
            Console.WriteLine("Dessine document HTML : " +
                              Contenu);
        }

        public void Imprime()
        {
            Console.WriteLine("Imprime document HTML : " +
                              Contenu);
        }

    }
}
