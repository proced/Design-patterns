namespace lp73.designPatterns.FactoryMethod
{
    public class ClientCredit : Client
    {
        protected override Commande CreeCommande(double montant)
        {
            return new CommandeCredit(montant);
        }
    }
}
