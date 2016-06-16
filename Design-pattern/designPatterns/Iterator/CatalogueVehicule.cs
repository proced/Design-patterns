namespace lp73.designPatterns.Iterator
{
    public class CatalogueVehicule : Catalogue<Vehicule,
        IterateurVehicule> 
    {

        public CatalogueVehicule()
        {
            Contenu.Add(new Vehicule("v�hicule bon march�"));
            Contenu.Add(new Vehicule("petit v�hicule bon march�"));
            Contenu.Add(new Vehicule("v�hicule grande qualit�"));
        }
    }
}
