namespace lp73.designPatterns.Bridge
{
    public abstract class FormulaireImmatriculation
    {
        protected string Contenu;
        protected IFormulaireImpl Implantation;

        public FormulaireImmatriculation(IFormulaireImpl
            implantation)
        {
            this.Implantation = implantation;
        }

        public void Affiche()
        {
            Implantation.DessineTexte(
                "numéro de la plaque existante : ");
        }

        public void GenereDocument()
        {
            Implantation.DessineTexte("Demande d'immatriculation");
            Implantation.DessineTexte("numéro de plaque : " +
                                      Contenu);
        }

        public bool GereSaisie()
        {
            Contenu = Implantation.GereZoneSaisie();
            return this.ControleSaisie(Contenu);
        }

        protected abstract bool ControleSaisie(string plaque);
    }
}
