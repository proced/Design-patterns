namespace lp73.designPatterns.FactoryMethod
{
    class ClientDifferee : Client
    {
        protected override Commande CreeCommande(double montant)
        {
            return new CommandeDifferee(montant);
        }
    }
}