using System;
namespace lp73.designPatterns.AbstractFactory
{
    public class Catalogue
    {
        public static int NbAutos = 3;
        public static int NbScooters = 2;

        public static void FabriqueVehicule()
        {
            AbstractFactory.IFabriqueVehicule fabrique;
            Automobile[] autos = new Automobile[nbAutos];
            Scooter[] scooters = new Scooter[nbScooters];
            Console.WriteLine("Voulez-vous utiliser " +
                              "des v�hicules �lectriques (1), � essence (2) ou hybrides (3) :");
            string choix = Console.ReadLine();
            if (choix == "1")
            {
                fabrique = new FabriqueVehiculeElectricite();
            }
            else if (choix == "2")
            {
                fabrique = new FabriqueVehiculeEssence();
            }
            else
            {
                fabrique = new FabriqueVehiculeHybride();
            }
            for (int index = 0; index < nbAutos; index++)
                autos[index] = fabrique.CreeAutomobile("standard",
                    "jaune", 6 + index, 3.2);
            for (int index = 0; index < nbScooters; index++)
                scooters[index] = fabrique.CreeScooter("classic",
                    "rouge", 2 + index);
            foreach (Automobile auto in autos)
                auto.AfficheCaracteristiques();
            foreach (Scooter scooter in scooters)
                scooter.AfficheCaracteristiques();
        }

    }
}
