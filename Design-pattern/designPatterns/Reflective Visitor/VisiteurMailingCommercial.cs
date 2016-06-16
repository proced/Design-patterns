using System;

namespace lp73.designPatterns.Reflective_Visitor
{
    public class VisiteurMailingCommercial : Visiteur, IVisiteurSociete
    {
        public void Visite(SocieteSansFiliale societe)
        {
            Console.WriteLine("Envoi d'un email à " +
                              societe.Nom + " adresse : " + societe.Email
                              + " Proposition commerciale pour votre société");
        }

        public void Visite(SocieteMere societe)
        {
            Console.WriteLine("Envoi d'un email à " +
                              societe.Nom + " adresse : " + societe.Email
                              + " Proposition commerciale pour votre groupe");
            Console.WriteLine("Impression d'un courrier à " +
                              societe.Nom + " adresse : " +
                              societe.Adresse + 
                              " Proposition commerciale pour votre groupe");
            foreach (Societe filiale in societe.Filiales)
                this.DemarreVisite(filiale);
        }
    }
}
