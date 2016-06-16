using System.Collections.Generic;

namespace lp73.designPatterns.Iterator
{
    public abstract class Catalogue<TElement, TIterateur>
        where TElement : Element
        where TIterateur : Iterateur<TElement>, new()
    {
        protected IList<TElement> Contenu = 
            new List<TElement>();

        public TIterateur Recherche(string motCleRequete)
        {
            TIterateur resultat = new TIterateur();
            resultat.MotCleRequete = motCleRequete;
            resultat.Contenu = Contenu;
            return resultat;
        }
    }
}
