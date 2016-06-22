using System;
namespace lp73.designPatterns.Builder
{
    public class ClientVehicule
    {
        public static void Liasses()
        {
            ConstructeurLiasseVehicule constructeur;
            Console.WriteLine("Voulez-vous construire " +
                              "des liasses HTML (1) ou PDF (2) ou XML (3):");
            string choix = Console.ReadLine();
            if (choix == "1")
            {
                constructeur = new ConstructeurLiasseVehiculeHtml();
            }
            else if(choix =="2")
            {
                constructeur = new ConstructeurLiasseVehiculePdf();
            }
            else
            {
                constructeur = new ConstructeurLiasseVehiculeXml();
            }
            Vendeur vendeur = new Vendeur(constructeur);
            Liasse liasse = vendeur.Construit("Martin");
            liasse.Imprime();
        }
    }
}
