namespace lp73.designPatterns.Builder
{
    public abstract class ConstructeurLiasseVehicule
    {
        protected Liasse Liasse;

        public abstract void ConstruitBonDeCommande(string
            nomClient);

        public abstract void ConstruitDemandeImmatriculation
            (string nomDemandeur);

        public Liasse Resultat()
        {
            return Liasse;
        }
    }
}
