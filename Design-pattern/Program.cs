using System;

namespace lp73
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Quel design pattern voulez-vous appeler ?\n" +
                                  "1  - AbstractFactory\n" +
                                  "2  - Adapter\n" +
                                  "3  - Bridge \n" +
                                  "4  - Builder\n" +
                                  "5  - Chain Of Responsibility\n" +
                                  "6  - Command\n" +
                                  "7  - Composite\n" +
                                  "8  - Decorator\n" +
                                  "9  - Facade\n" +
                                  "10 - Factory Method\n" +
                                  "11 - FlyWeight\n" +
                                  "12 - Interpreter\n" +
                                  "13 - Iterator\n" +
                                  "14 - Mediator\n" +
                                  "15 - Memento\n" +
                                  "16 - Multicast\n" +
                                  "17 - Observer\n" +
                                  "18 - Pluggable Factory\n" +
                                  "19 - Prototype\n" +
                                  "20 - Proxy\n" +
                                  "21 - Reflective Visitor\n" +
                                  "22 - Singleton\n" +
                                  "23 - State\n" +
                                  "24 - Strategy\n" +
                                  "25 - Template Method\n" +
                                  "26 - Visitor");
                string choix = Console.ReadLine();
                switch (choix)
                {
                    case "1":
                        //Abstract Factory
                        designPatterns.AbstractFactory.Catalogue.FabriqueVehicule();
                        break;
                    case "2":
                        //Adapter
                        designPatterns.Adapter.ServeurWeb.NouveauxDocuments();
                        break;
                    case "3":
                        //Bridge
                        designPatterns.Bridge.Utilisateur.NouveauxFormulaires();
                        break;
                    case "4":
                        //Builder
                        designPatterns.Builder.ClientVehicule.Liasses();
                        break;
                    case "5":
                        // Chain Of Responsibility
                        designPatterns.ChainOfResponsibility.Utilisateur.Vehicule();
                        break;
                    case "6":
                        //Command
                        designPatterns.Command.Utilisateur.CommandVehicule();
                        break;
                    case "7":
                        //Composite
                        designPatterns.Composite.Utilisateur.SocieteGroupe();
                        break;
                    case "8":
                        //Decorator
                        designPatterns.Decorator.VueCatalogue.VueVehicule();
                        break;
                    case "9":
                        //Facade
                        designPatterns.Facade.UtilisateurWebService.WebService();
                        break;
                    case "10":
                        //FactoryMethod
                        designPatterns.FactoryMethod.Utilisateur.NouveauClient();
                        break;
                    case "11":
                        //FlyWeight
                        designPatterns.Flyweight.Client.NouvelleCommande();
                        break;
                    case "12":
                        //Interpreter
                        designPatterns.Interpreter.Utilisateur.Requete();
                        break;
                    case "13":
                        // Iterator
                        designPatterns.Iterator.Utilisateur.Iterator("bon marché");
                        break;
                    case "14":
                        // Mediator
                        designPatterns.Mediator.Utilisateur.Mediator();
                        break;
                    case "15":
                        // Memento
                        designPatterns.Memento.Utilisateur.Memento();
                        break;
                    case "16":
                        // Multicast
                       // designPatterns.Multicast.Concession.Multicast();
                        break;
                    case "17":
                        // Observer
                        designPatterns.Observer.Utilisateur.Observer();
                        break;
                    case "18":
                        // PluggableFactory
                    //    designPatterns.PluggableFactory.Utilisateur.PluggableFactory();
                        break;
                    case "19":
                        // Prototype
                        designPatterns.Prototype.Utilisateur.Prototype();
                        break;
                    case "20":
                        // Proxy
                        designPatterns.Proxy.VueVehicule.Proxy();
                        break;
                    case "21":
                        // Reflective visitor
                    //    designPatterns.Reflective_Visitor.Utilisateur.ReflectiveVisitor();
                        break;
                    case "22":
                        // Singleton
                        designPatterns.Singleton.TestVendeur.Singleton();
                        break;
                    case "23":
                        // State
                        designPatterns.State.Utilisateur.State();
                        break;
                    case "24":
                        // Strategy
                        designPatterns.Strategy.Utilisateur.Strategy();
                        break;
                    case "25":
                        // TemplateMethod
                        designPatterns.TemplateMethod.Utilisateur.TemplateMethod();
                        break;
                    case "26":
                        // Visitor
                        designPatterns.Visitor.Utilisateur.Visitor();
                        break;
                    case "27":
                        // Interpreter
                        designPatterns.Interpreter.Utilisateur.Requete();
                        break;
                }
                Console.ReadKey();
            }
            
        }
    }
}
