namespace lp73.designPatterns.PluggableFactory
{
    public class FabriqueVehicule
    {
        public Automobile PrototypeAutomobile { get; set; }
        public Scooter PrototypeScooter { get; set; }

        public FabriqueVehicule()
        {
            PrototypeAutomobile = null;
            PrototypeScooter = null;
        }

        public FabriqueVehicule(Automobile prototypeAutomobile,
            Scooter prototypeScooter)
        {
            this.PrototypeAutomobile = prototypeAutomobile;
            this.PrototypeScooter = prototypeScooter;
        }

        public Automobile CreeAutomobile()
        {
            if (PrototypeAutomobile == null)
                return null;
            return PrototypeAutomobile.Duplique();
        }

        public Scooter CreeScooter()
        {
            if (PrototypeScooter == null)
                return null;
            return PrototypeScooter.Duplique();
        }
    }
}

