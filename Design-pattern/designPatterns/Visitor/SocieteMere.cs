using System.Collections.Generic;

namespace lp73.designPatterns.Visitor
{
    public class SocieteMere : Societe
    {
        protected IList<Societe> Filiales = 
            new List<Societe>();

        public SocieteMere(string nom, string email, string
            adresse) : base(nom, email, adresse){}

        public override void AccepteVisiteur(IVisiteur visiteur)
        {
            visiteur.Visite(this);
            foreach (Societe filiale in Filiales)
                filiale.AccepteVisiteur(visiteur);
        }

        public override bool AjouteFiliale(Societe filiale)
        {
            Filiales.Add(filiale);
            return true;
        }
    }
}
