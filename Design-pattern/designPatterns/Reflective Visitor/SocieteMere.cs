using System.Collections.Generic;

namespace lp73.designPatterns.Reflective_Visitor
{
    public class SocieteMere : Societe
    {
        public IList<Societe> filiales {get; protected set;} 

        public SocieteMere(string nom, string email, string
            adresse)
            : base(nom, email, adresse)
        {
            filiales = new List<Societe>();
        }

        public override bool ajouteFiliale(Societe filiale)
        {
            filiales.Add(filiale);
            return true;
        }
    }
}
