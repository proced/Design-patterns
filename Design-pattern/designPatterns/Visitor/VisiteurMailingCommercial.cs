using System;

namespace lp73.designPatterns.Visitor
{
    public class VisiteurMailingCommercial : IVisiteur
    {
        public void Visite(SocieteSansFiliale
            societe)
        {
            Console.WriteLine("Envoi d'un email � " +
                              societe.Nom + " adresse : " + societe.Email
                              + " Proposition commerciale pour votre soci�t�");
        }

        public void Visite(SocieteMere societe)
        {
            Console.WriteLine("Envoi d'un email � " +
                              societe.Nom + " adresse : " + societe.Email
                              + " Proposition commerciale pour votre groupe");
            Console.WriteLine("Impression d'un courrier � " +
                              societe.Nom + " adresse : " +
                              societe.Adresse + 
                              " Proposition commerciale pour votre groupe");
        }
    }
}
