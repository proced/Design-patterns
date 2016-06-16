namespace lp73.designPatterns.Observer
{
    public class Vehicule : Sujet
    {
        private string _description;
        private double _prix;

        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
                this.notifie();
            }
        }

        public double Prix
        {
            get
            {
                return _prix;
            }
            set
            {
                _prix = value;
                this.notifie();
            }
        }

    }
}
