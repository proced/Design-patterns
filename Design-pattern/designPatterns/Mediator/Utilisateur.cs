namespace lp73.designPatterns.Mediator
{
    public class Utilisateur
    {
        public static void Mediator()
        {
            Formulaire formulaire = new Formulaire();
            formulaire.AjouteControle(new ZoneSaisie("Nom"));
            formulaire.AjouteControle(new ZoneSaisie("Prénom"));
            PopupMenu menu = new PopupMenu("Coemprunteur");
            menu.ajouteOption("sans coemprunteur");
            menu.ajouteOption("avec coemprunteur");
            formulaire.AjouteControle(menu);
            formulaire.MenuCoemprunteur = menu;
            Bouton bouton = new Bouton("OK");
            formulaire.AjouteControle(bouton);
            formulaire.BoutonOk = bouton;
            formulaire.AjouteControleCoemprunteur(new ZoneSaisie(
                "Nom du coemprunteur"));
            formulaire.AjouteControleCoemprunteur(new ZoneSaisie(
                "Prénom du coemprunteur"));
            formulaire.Saisie();
        }
    }
}
