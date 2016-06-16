﻿using System;
using System.Reflection;

namespace lp73.designPatterns.Reflective_Visitor
{
    public abstract class Visiteur
    {
        public void demarreVisite(Visitable visitable)
        {
            MethodInfo infoMethode = this.GetType().GetMethod("visite",
                new Type[] { visitable.GetType() });
            infoMethode.Invoke(this, new object[] { visitable });
        }

        public void visite(Visitable visitable)
        {
            Console.WriteLine("Visite par défaut");
        }
    }
}