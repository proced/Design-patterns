namespace lp73.designPatterns.FactoryMethod
{
    public class Utilisateur
    {
        public static void NouveauClient()
        {
            Client client;
            client = new ClientComptant();
            client.nouvelleCommande(2000.0);
            client.nouvelleCommande(10000.0);
            client = new ClientCredit();
            client.nouvelleCommande(2000.0);
            client.nouvelleCommande(10000.0);
        }
    }
}
