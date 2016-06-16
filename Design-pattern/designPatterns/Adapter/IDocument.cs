namespace lp73.designPatterns.Adapter
{
    public interface IDocument
    {
        string Contenu { set; }
        void Dessine();
        void Imprime();
    }
}
