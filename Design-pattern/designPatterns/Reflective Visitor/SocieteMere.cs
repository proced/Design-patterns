using System.Collections.Generic;

namespace lp73.designPatterns.Reflective_Visitor
{
    public class SocieteMere : Societe
    {
        public IList<Societe> Filiales {get; protected set;} 

        public SocieteMere(string nom, string email, string
            adresse)
            : base(nom, email, adresse)
        {
            Filiales = new List<Societe>();
        }

        public override bool AjouteFiliale(Societe filiale)
        {
            Filiales.Add(filiale);
            return true;
        }
    }
}
