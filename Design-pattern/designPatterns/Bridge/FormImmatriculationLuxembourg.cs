namespace lp73.designPatterns.Bridge
{
    public class FormImmatriculationLuxembourg :
        FormulaireImmatriculation
    {
        public FormImmatriculationLuxembourg(IFormulaireImpl
            implantation) : base(implantation){}

        protected override bool ControleSaisie(string plaque)
        {
            return plaque.Length == 5;
        }
    }
}
