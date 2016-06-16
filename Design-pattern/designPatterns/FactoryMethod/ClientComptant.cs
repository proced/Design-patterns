namespace lp73.designPatterns.FactoryMethod
{
    public class ClientComptant : Client
    {
        protected override Commande creeCommande(double montant)
        {
            return new CommandeComptant(montant);
        }
    }
}
