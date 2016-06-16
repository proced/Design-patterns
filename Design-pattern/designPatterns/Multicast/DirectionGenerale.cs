using System.Collections.Generic;

namespace lp73.designPatterns.Multicast
{
    public class DirectionGenerale
    {
        protected ExpediteurGeneral ExpediteurGeneral = new
            ExpediteurGeneral();

        public void EnvoieMessages()
        {
            IList<string> contenu = new List<string>();
            contenu.Add("Informations générales");
            contenu.Add("Informations spécifiques");
            MessageGeneral message = new MessageGeneral(contenu);
            ExpediteurGeneral.EnvoieMultiple(message);
        }

        public void AjouteRecepteurGeneral(Employe recepteur)
        {
            ExpediteurGeneral.Ajoute(recepteur);
        }
    }
}

