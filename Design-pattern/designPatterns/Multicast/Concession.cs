namespace lp73.designPatterns.Multicast
{
    public class Concession
    {
        public static void Multicast()
        {
            DirectionGenerale directionGenerale = new
                DirectionGenerale();
            DirectionCommerciale directionCommerciale = new
                DirectionCommerciale();
            Commercial commercial1 = new Commercial("Paul");
            Commercial commercial2 = new Commercial("Henri");
            Administratif administratif = new Administratif(
                "Jacques");
            directionGenerale.AjouteRecepteurGeneral(commercial1);
            directionGenerale.AjouteRecepteurGeneral(commercial2);
            directionGenerale.AjouteRecepteurGeneral
                (administratif);
            directionGenerale.EnvoieMessages();
            directionCommerciale.AjouteRecepteurCommercial
                (commercial1);
            directionCommerciale.AjouteRecepteurCommercial
                (commercial2);
            directionCommerciale.envoieMessages();
        }
    }
}

