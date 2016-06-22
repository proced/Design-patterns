using System.Collections.Generic;

namespace lp73.designPatterns.Builder
{
    public abstract class Liasse
    {
        protected IList<string> Contenu = 
            new List<string>();

        public abstract void AjouteDocument(string document);
        public abstract void Imprime();
    }
}
