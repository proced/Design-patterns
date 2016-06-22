using System.Collections.Generic;

namespace lp73.designPatterns.Observer
{
    public abstract class Sujet
    {
        protected IList<IObservateur> Observateurs = 
            new List<IObservateur>();

        public void Ajoute(IObservateur observateur)
        {
            Observateurs.Add(observateur);
        }

        public void Retire(IObservateur observateur)
        {
            Observateurs.Remove(observateur);
        }

        public void Notifie()
        {
            foreach (IObservateur observateur in Observateurs)
                observateur.Actualise();
        }
    }
}
