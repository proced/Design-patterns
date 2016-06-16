namespace lp73.designPatterns.Adapter
{
    public interface Document
    {
        string contenu { set; }
        void dessine();
        void imprime();
    }
}
