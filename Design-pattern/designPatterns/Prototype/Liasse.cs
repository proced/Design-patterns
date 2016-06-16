using System.Collections.Generic;

namespace lp73.designPatterns.Prototype
{
    public abstract class Liasse
    {
        public IList<Document> Documents { get; protected set; }
    }
}
