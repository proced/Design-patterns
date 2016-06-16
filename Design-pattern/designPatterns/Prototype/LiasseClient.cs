using System.Collections.Generic;

namespace lp73.designPatterns.Prototype
{
    public class LiasseClient : Liasse
    {
        public LiasseClient(string informations)
        {
            Documents = new List<Document>();
            LiasseVierge laLiasseVierge = LiasseVierge.Instance();
            IList<Document> documentsVierges =
                laLiasseVierge.Documents;
            foreach (Document document in documentsVierges)
            {
                Document copieDocument = document.Duplique();
                copieDocument.Remplit(informations);
                Documents.Add(copieDocument);
            }
        }

        public void Affiche()
        {
            foreach (Document document in Documents)
                document.Affiche();
        }

        public void Imprime()
        {
            foreach (Document document in Documents)
                document.Imprime();
        }
    }
}
