namespace lp73.designPatterns.TemplateMethod
{
    public class Utilisateur
    {
        public static void TemplateMethod()
        {
            Commande commandeFrance = new CommandeFrance();
            commandeFrance.SetMontantHt(10000);
            commandeFrance.CalculeMontantTtc();
            commandeFrance.Affiche();


            Commande commandeLuxembourg = new CommandeLuxembourg();
            commandeLuxembourg.SetMontantHt(10000);
            commandeLuxembourg.CalculeMontantTtc();
            commandeLuxembourg.Affiche();
        }
    }
}
