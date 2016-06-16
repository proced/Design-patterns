namespace lp73.designPatterns.Multicast
{
    public class DirectionCommerciale
    {
        protected ExpediteurCommercial expediteurCommercial =
            new ExpediteurCommercial();

        public void envoieMessages()
        {
            MessageCommercial message = new MessageCommercial(
                "Annonce nouvelle gamme");
            expediteurCommercial.EnvoieMultiple(message);
            message = new MessageCommercial(
                "Annonce suppression modèle");
            expediteurCommercial.EnvoieMultiple(message);
        }

        public void AjouteRecepteurCommercial
            (IRecepteurCommercial recepteur)
        {
            expediteurCommercial.Ajoute(recepteur);
        }
    }
}

