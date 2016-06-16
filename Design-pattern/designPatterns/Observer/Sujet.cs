using System.Collections.Generic;

namespace lp73.designPatterns.Observer
{
    public abstract class Sujet
    {
        protected IList<Observateur> Observateurs = 
            new List<Observateur>();

        public void Ajoute(Observateur observateur)
        {
            Observateurs.Add(observateur);
        }

        public void retire(Observateur observateur)
        {
            Observateurs.Remove(observateur);
        }

        public void notifie()
        {
            foreach (Observateur observateur in Observateurs)
                observateur.actualise();
        }
    }
}
