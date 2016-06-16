namespace lp73.designPatterns.PluggableFactory
{
    class Utilisateur
    {
        public static void PluggableFactory()
        {
            Automobile protoAutomobileStandardBleu = new
                AutomobileElectricite();
            protoAutomobileStandardBleu.Modele = "standard";
            protoAutomobileStandardBleu.Couleur = "bleu";

            Scooter protoScooterClassicRouge = new ScooterEssence();
            protoScooterClassicRouge.Modele = "classic";
            protoScooterClassicRouge.Couleur = "rouge";

            FabriqueVehicule fabrique = new FabriqueVehicule();
            fabrique.PrototypeAutomobile =
                protoAutomobileStandardBleu;
            fabrique.PrototypeScooter = protoScooterClassicRouge;

            Automobile auto = fabrique.CreeAutomobile();
            auto.AfficheCaracteristiques();
            Scooter scooter = fabrique.CreeScooter();
            scooter.AfficheCaracteristiques();
        }
    }
}

