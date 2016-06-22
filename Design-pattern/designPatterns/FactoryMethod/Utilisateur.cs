namespace lp73.designPatterns.FactoryMethod
{
    public class Utilisateur
    {
        public static void NouveauClient()
        {
            Client client;
            client = new ClientComptant();
            client.NouvelleCommande(2000.0);
            client.NouvelleCommande(10000.0);
            client = new ClientCredit();
            client.NouvelleCommande(2000.0);
            client.NouvelleCommande(10000.0);
            client = new ClientDifferee();
            client.NouvelleCommande(2000);
            client.NouvelleCommande(10000);
        }
    }
}
