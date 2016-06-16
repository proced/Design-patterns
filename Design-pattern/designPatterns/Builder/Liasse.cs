using System.Collections.Generic;

namespace lp73.designPatterns.Builder
{
    public abstract class Liasse
    {
        protected IList<string> contenu = 
            new List<string>();

        public abstract void ajouteDocument(string document);
        public abstract void imprime();
    }
}
