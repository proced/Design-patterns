using System.Collections.Generic;

namespace lp73.designPatterns.Iterator
{
    public abstract class Iterateur<TElement>
        where TElement : Element
    {
        public string MotCleRequete { protected get; set; }
        protected int Index;
        public IList<TElement> Contenu { protected get; set; }


        public void Debut()
        {
            Index = 0;
            int taille = Contenu.Count;
            while ((Index < taille) && 
                   (!Contenu[Index].MotCleValide(MotCleRequete)))
                Index++;
        }

        public void Suivant()
        {
            int taille = Contenu.Count;
            Index++;
            while ((Index < taille) && 
                   (!Contenu[Index].MotCleValide(MotCleRequete)))
                Index++;
        }

        public TElement Item()
        {
            return Index < Contenu.Count ? Contenu[Index] : null;
        }
    }
}
