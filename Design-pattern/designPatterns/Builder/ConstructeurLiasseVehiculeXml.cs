namespace lp73.designPatterns.Builder
{
    public class ConstructeurLiasseVehiculeXml:
        ConstructeurLiasseVehicule
    {
        public ConstructeurLiasseVehiculeXml()
        {
            Liasse = new LiasseXml();
        }

        public override void ConstruitBonDeCommande(string
            nomClient)
        {
            string document;
            document = "<XML>Bon de commande Client : " +
                       nomClient + "</XML>";
            Liasse.AjouteDocument(document);
        }

        public override void ConstruitDemandeImmatriculation
            (string nomDemandeur)
        {
            string document;
            document = 
                "<XML>Demande d'immatriculation Demandeur : " +
                nomDemandeur + "</XML>";
            Liasse.AjouteDocument(document);
        }
    }
}