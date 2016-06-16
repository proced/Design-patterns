using System;
using System.Reflection;

namespace lp73.designPatterns.Reflective_Visitor
{
    public abstract class Visiteur
    {
        public void DemarreVisite(IVisitable visitable)
        {
            MethodInfo infoMethode = this.GetType().GetMethod("visite",
                new Type[] { visitable.GetType() });
            infoMethode.Invoke(this, new object[] { visitable });
        }

        public void Visite(IVisitable visitable)
        {
            Console.WriteLine("Visite par défaut");
        }
    }
}