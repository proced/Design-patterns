namespace lp73.designPatterns.Visitor
{
    public class Utilisateur
    {
        public static void Visitor()
        {
            Societe societe1 = new SocieteSansFiliale("société1",
                "info@societe1.com", "rue de la société 1");
            Societe societe2 = new SocieteSansFiliale("société2",
                "info@societe2.com", "rue de la société 2");
            Societe groupe1 = new SocieteMere("groupe1", 
                "info@groupe1.com", "rue du groupe 1");
            groupe1.AjouteFiliale(societe1);
            groupe1.AjouteFiliale(societe2);
            Societe societe3 = new SocieteSansFiliale("société3",
                "info@societe3.com", "rue de la société 3");
            Societe groupe2 = new SocieteMere("groupe2", 
                "info@groupe2.com", "rue du groupe 2");
            groupe2.AjouteFiliale(groupe1);
            groupe2.AjouteFiliale(societe3);
            groupe2.AccepteVisiteur(new VisiteurMailingCommercial
                ());
        }
      
    }
}
