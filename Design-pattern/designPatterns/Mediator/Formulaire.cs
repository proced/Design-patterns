using System.Collections.Generic;

namespace lp73.designPatterns.Mediator
{
    public class Formulaire
    {
        protected IList<Controle> Controles = 
            new List<Controle>();
        protected IList<Controle> ControlesCoemprunteur =
            new List<Controle>();
        public PopupMenu MenuCoemprunteur { protected get; set; }
        public Bouton BoutonOk { protected get; set; }
        protected bool EnCours = true;

        public void AjouteControle(Controle controle)
        {
            Controles.Add(controle);
            controle.Directeur = this;
        }

        public void AjouteControleCoemprunteur(Controle
            controle)
        {
            ControlesCoemprunteur.Add(controle);
            controle.Directeur = this;
        }

        public void ControleModifie(Controle controle)
        {
            if (controle == MenuCoemprunteur) 
                if (controle.Valeur == "avec coemprunteur")
                {
                    foreach (Controle elementCoemprunteur in
                        ControlesCoemprunteur)
                        elementCoemprunteur.Saisie();
                }
            if (controle == BoutonOk)
            {
                EnCours = false;
            }
        }

        public void Saisie()
        {
            while (true)
            {
                foreach (Controle controle in Controles)
                {
                    controle.Saisie();
                    if (!EnCours)
                        return ;
                }
            }
        }

    }
}
