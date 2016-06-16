namespace lp73.designPatterns.Memento
{
    public class Utilisateur
    {
        public static void Memento()
        {
            OptionVehicule option1 = new OptionVehicule(
                "Sièges en cuir");
            OptionVehicule option2 = new OptionVehicule(
                "Accoudoirs");
            OptionVehicule option3 = new OptionVehicule(
                "Sièges sportifs");
            option1.AjouteOptionIncompatible(option3);
            option2.AjouteOptionIncompatible(option3);
            ChariotOption chariotOptions = new ChariotOption();
            chariotOptions.AjouteOption(option1);
            chariotOptions.AjouteOption(option2);
            chariotOptions.Affiche();
            var memento = chariotOptions.AjouteOption(option3);
            chariotOptions.Affiche();
            chariotOptions.Annule(memento);
            chariotOptions.Affiche();
        }
    }
}
