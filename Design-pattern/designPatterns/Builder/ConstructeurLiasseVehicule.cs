namespace lp73.designPatterns.Builder
{
    public abstract class ConstructeurLiasseVehicule
    {
        protected Liasse liasse;

        public abstract void construitBonDeCommande(string
            nomClient);

        public abstract void construitDemandeImmatriculation
            (string nomDemandeur);

        public Liasse resultat()
        {
            return liasse;
        }
    }
}
