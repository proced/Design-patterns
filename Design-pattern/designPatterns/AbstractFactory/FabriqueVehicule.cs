namespace lp73.designPatterns.AbstractFactory
{
    public interface IFabriqueVehicule
    {
        Automobile CreeAutomobile(string modele, string couleur,
            int puissance, double espace);

        Scooter CreeScooter(string modele, string couleur, int
            puissance);
    }
}
