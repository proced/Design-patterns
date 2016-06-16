namespace lp73.designPatterns.Composite
{
    public class SocieteSansFiliale : Societe
    {
        public override bool ajouteFiliale(Societe filiale)
        {
            return false;
        }

        public override double calculeCoutEntretien()
        {
            return nbrVehicules * coutUnitVehicule;
        }
    }
}
