namespace lp73.designPatterns.Bridge
{
    public class FormImmatriculationFrance :
        FormulaireImmatriculation
    {
        public FormImmatriculationFrance(IFormulaireImpl
            implantation) : base(implantation){}

        protected override bool ControleSaisie(string plaque)
        {
            return plaque.Length == 7;
        }
    }
}
