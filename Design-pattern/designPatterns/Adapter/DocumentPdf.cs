namespace lp73.designPatterns.Adapter
{
    public class DocumentPdf : Document
    {
        protected ComposantPdf outilPdf = new ComposantPdf();

        public string contenu
        {
            set
            {
                outilPdf.pdfFixeContenu(value);
            }
        }

        public void dessine()
        {
            outilPdf.pdfPrepareAffichage();
            outilPdf.pdfRafraichit();
            outilPdf.pdfTermineAffichage();
        }

        public void imprime()
        {
            outilPdf.pdfEnvoieImprimante();
        }
    }
}
