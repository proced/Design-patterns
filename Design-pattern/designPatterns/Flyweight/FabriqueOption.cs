using System.Collections.Generic;

namespace lp73.designPatterns.Flyweight
{
    public class FabriqueOption
    {
        protected IDictionary<string, OptionVehicule> options
            = new Dictionary<string, OptionVehicule>();
        public OptionVehicule getOption(string nom)
        {
            OptionVehicule resultat;
            if (options.ContainsKey(nom))
                resultat = options[nom];
            else
            {
                resultat = new OptionVehicule(nom);
                options.Add(nom, resultat);
            }
            return resultat;
        }
    }
}
