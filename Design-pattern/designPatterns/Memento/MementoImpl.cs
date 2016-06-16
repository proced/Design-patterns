using System.Collections.Generic;

namespace lp73.designPatterns.Memento
{
    public class MementoImpl : Memento
    {
        protected IList<OptionVehicule> options = 
            new List<OptionVehicule>();

        public IList<OptionVehicule> etat
        {
            get
            {
                return options;
            }
            set
            {
                this.options.Clear();
                foreach (OptionVehicule option in value)
                    this.options.Add(option);
            }
        }
    }
}
