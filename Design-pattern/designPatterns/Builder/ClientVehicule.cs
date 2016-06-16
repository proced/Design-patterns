using System;
namespace lp73.designPatterns.Builder
{
    public class ClientVehicule
    {
        public static void Liasses()
        {
            ConstructeurLiasseVehicule constructeur;
            Console.WriteLine("Voulez-vous construire " +
                              "des liasses HTML (1) ou PDF (2) :");
            string choix = Console.ReadLine();
            if (choix == "1")
            {
                constructeur = new ConstructeurLiasseVehiculeHtml();
            }
            else
            {
                constructeur = new ConstructeurLiasseVehiculePdf();
            }
            Vendeur vendeur = new Vendeur(constructeur);
            Liasse liasse = vendeur.construit("Martin");
            liasse.imprime();
        }
    }
}
