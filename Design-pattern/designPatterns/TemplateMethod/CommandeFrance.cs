namespace lp73.designPatterns.TemplateMethod
{
    public class CommandeFrance : Commande
    {
        protected override void CalculeTva()
        {
            MontantTva = MontantHt * 0.196;
        }
    }
}
