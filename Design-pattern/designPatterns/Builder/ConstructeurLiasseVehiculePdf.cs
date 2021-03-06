namespace lp73.designPatterns.Builder
{
    public class ConstructeurLiasseVehiculePdf :
        ConstructeurLiasseVehicule
    {
        public ConstructeurLiasseVehiculePdf()
        {
            Liasse = new LiassePdf();
        }

        public override void ConstruitBonDeCommande(string
            nomClient)
        {
            string document;
            document = "<PDF>Bon de commande Client : " +
                       nomClient + "</PDF>";
            Liasse.AjouteDocument(document);
        }

        public override void ConstruitDemandeImmatriculation
            (string nomDemandeur)
        {
            string document;
            document = 
                "<PDF>Demande d'immatriculation Demandeur : " +
                nomDemandeur + "</PDF>";
            Liasse.AjouteDocument(document);
        }
    }
}
