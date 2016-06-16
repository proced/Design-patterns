namespace lp73.designPatterns.Mediator
{
    public abstract class Controle
    {
        public string Valeur { get; protected set; }
        public Formulaire Directeur { get;  set;}
        public string Nom { get; protected set; }

        protected Controle(string nom)
        {
            this.Valeur = "";
            this.Nom = nom;
        }

        public abstract void Saisie();

        protected void Modifie()
        {
            Directeur.ControleModifie(this);
        }
    }
}
