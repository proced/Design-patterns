using System;

namespace lp73.designPatterns.Iterator
{
    public abstract class Element
    {
        protected string Description;

        protected Element(string description)
        {
            this.Description = description;
        }

        public bool MotCleValide(string motCle)
        {
            return Description.IndexOf(motCle, StringComparison.Ordinal) !=  -1;
        }
    }
}
