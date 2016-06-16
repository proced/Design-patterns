using System.Collections.Generic;

namespace lp73.designPatterns.Memento
{
    public class MementoImpl : IMemento
    {
        protected IList<OptionVehicule> Options = 
            new List<OptionVehicule>();

        public IList<OptionVehicule> Etat
        {
            get
            {
                return Options;
            }
            set
            {
                this.Options.Clear();
                foreach (OptionVehicule option in value)
                    this.Options.Add(option);
            }
        }
    }
}
