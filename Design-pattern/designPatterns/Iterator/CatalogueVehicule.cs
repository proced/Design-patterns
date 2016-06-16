namespace lp73.designPatterns.Iterator
{
    public class CatalogueVehicule : Catalogue<Vehicule,
        IterateurVehicule> 
    {

        public CatalogueVehicule()
        {
            Contenu.Add(new Vehicule("véhicule bon marché"));
            Contenu.Add(new Vehicule("petit véhicule bon marché"));
            Contenu.Add(new Vehicule("véhicule grande qualité"));
        }
    }
}
