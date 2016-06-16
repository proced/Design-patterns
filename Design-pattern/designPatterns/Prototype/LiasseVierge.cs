using System.Collections.Generic;

namespace lp73.designPatterns.Prototype
{
    public class LiasseVierge : Liasse
    {
        private static LiasseVierge _instance = null;

        private LiasseVierge()
        {
            Documents = new List<Document>();
        }

        public static LiasseVierge Instance()
        {
            if (_instance == null)
                _instance = new LiasseVierge();
            return _instance;
        }

        public void Ajoute(Document doc)
        {
            Documents.Add(doc);
        }

        public void Retire(Document doc)
        {
            Documents.Remove(doc);
        }
    }
}
