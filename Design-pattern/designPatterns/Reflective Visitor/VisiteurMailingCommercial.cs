using System;

namespace lp73.designPatterns.Reflective_Visitor
{
    public class VisiteurMailingCommercial : Visiteur, IVisiteurSociete
    {
        public void Visite(SocieteSansFiliale societe)
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
            foreach (Societe filiale in societe.Filiales)
                this.DemarreVisite(filiale);
        }
    }
}
