using System;
namespace lp73
{
    class Maxime
    {
        public static void MainMaxime()
        {
            while (true)
            {
                Console.WriteLine("Quel design pattern voulez-vous appeler ?" +
                                  "AbstractFactory (1), Adapter (2), Bridge (3), Builder (4), Chain Of Responsibility (5), Command (6), Composite (7), Decorator (8), Facade (9), FactoryMethod (10), FlyWeight (11), Interpreter (12):");
                string choix = Console.ReadLine();
                if (choix == "1")
                {
                    //Abstract Factory
                    designPatterns.AbstractFactory.Catalogue.FabriqueVehicule();
                }
                else if (choix == "2")
                {
                    //Adapter
                    designPatterns.Adapter.ServeurWeb.NouveauxDocuments();
                }
                else if (choix == "3")
                {
                    //Bridge
                    designPatterns.Bridge.Utilisateur.NouveauxFormulaires();
                }
                else if (choix == "4")
                {
                    //Builder
                    designPatterns.Builder.ClientVehicule.Liasses();
                }
                else if (choix == "5")
                {
                    // Chain Of Responsibility
                    designPatterns.ChainOfResponsibility.Utilisateur.Vehicule();
                }
                else if (choix == "6")
                {
                    //Command
                    designPatterns.Command.Utilisateur.CommandVehicule();
                }
                else if (choix == "7")
                {
                    //Composite
                    designPatterns.Composite.Utilisateur.SocieteGroupe();
                }
                else if (choix == "8")
                {
                    //Decorator
                    designPatterns.Decorator.VueCatalogue.VueVehicule();
                }
                else if (choix == "9")
                {
                    //Facade
                    designPatterns.Facade.UtilisateurWebService.WebService();
                }
                else if (choix == "10")
                {
                    //FactoryMethod
                    designPatterns.FactoryMethod.Utilisateur.NouveauClient();
                }
                else if (choix == "11")
                {
                    //FlyWeight
                    designPatterns.Flyweight.Client.NouvelleCommande();
                }
                else if (choix == "12")
                {
                    //Interpreter
                    designPatterns.Interpreter.Utilisateur.Requete();
                }
            }

           

            

        }
    }
}
