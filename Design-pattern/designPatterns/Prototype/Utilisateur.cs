namespace lp73.designPatterns.Prototype
{
    public class Utilisateur
    {
        public static void Prototype()
        {
            LiasseVierge liasseVierge = LiasseVierge.Instance();
            liasseVierge.Ajoute(new BonDeCommande());
            liasseVierge.Ajoute(new CertificatCession());
            liasseVierge.Ajoute(new DemandeImmatriculation());
            liasseVierge.Ajoute(new Facture());
            // création d'une nouvelle liasse pour deux clients
            LiasseClient liasseClient1 = new LiasseClient(
                "Martin");
            LiasseClient liasseClient2 = new LiasseClient(
                "Durant");
            LiasseClient liasseClient3 = new LiasseClient(
                "Dupont");
            liasseClient1.Affiche();
            liasseClient2.Affiche();
            liasseClient3.Affiche();
        }
    }
}
