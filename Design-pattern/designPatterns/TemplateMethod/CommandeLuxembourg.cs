namespace lp73.designPatterns.TemplateMethod
{
    public class CommandeLuxembourg : Commande
    {
        protected override void CalculeTva()
        {
            MontantTva = MontantHt * 0.15;
        }
    }
}
