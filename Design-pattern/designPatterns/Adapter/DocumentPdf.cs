namespace lp73.designPatterns.Adapter
{
    public class DocumentPdf : IDocument
    {
        protected ComposantPdf OutilPdf = new ComposantPdf();

        public string Contenu
        {
            set
            {
                OutilPdf.PdfFixeContenu(value);
            }
        }

        public void Dessine()
        {
            OutilPdf.PdfPrepareAffichage();
            OutilPdf.PdfRafraichit();
            OutilPdf.PdfTermineAffichage();
        }

        public void Imprime()
        {
            OutilPdf.PdfEnvoieImprimante();
        }
    }
}
