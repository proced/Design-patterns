using System;
namespace lp73.designPatterns.AbstractFactory
{
    public class Catalogue
    {
        public static int NbAutos = 3;
        public static int NbScooters = 2;

        public static void FabriqueVehicule()
        {
            IFabriqueVehicule fabrique;
            Automobile[] autos = new Automobile[NbAutos];
            Scooter[] scooters = new Scooter[NbScooters];
            Console.WriteLine("Voulez-vous utiliser " +
                              "des véhicules électriques (1) ou à essence (2) :");
            string choix = Console.ReadLine();
            if (choix == "1")
            {
                fabrique = new FabriqueVehiculeElectricite();
            }
            else
            {
                fabrique = new FabriqueVehiculeEssence();
            }
            for (int index = 0; index < NbAutos; index++)
                autos[index] = fabrique.CreeAutomobile("standard",
                    "jaune", 6 + index, 3.2);
            for (int index = 0; index < NbScooters; index++)
                scooters[index] = fabrique.CreeScooter("classic",
                    "rouge", 2 + index);
            foreach (Automobile auto in autos)
                auto.AfficheCaracteristiques();
            foreach (Scooter scooter in scooters)
                scooter.AfficheCaracteristiques();
        }

    }
}
