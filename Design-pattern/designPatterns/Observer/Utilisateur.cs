namespace lp73.designPatterns.Observer
{
    public class Utilisateur
    {
        public static void Observer()
        {
            Vehicule vehicule = new Vehicule();
            vehicule.Description = "Vehicule bon marché";
            vehicule.Prix = 5000.0;
            Observer.VueVehicule vueVehicule = new Observer.VueVehicule(vehicule);
            vueVehicule.Redessine();
            vehicule.Prix = 4500.0;
            Observer.VueVehicule vueVehicule2 = new Observer.VueVehicule(vehicule);
            vehicule.Prix = 5500.0;
        }
    }
}
