namespace lp73.designPatterns.Facade
{
    public class ComposantGestionDocument : GestionDocument
    {

        public string document(int index)
        {
            return "Document numéro " + index;
        }
    }
}
