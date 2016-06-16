using System;

namespace lp73.designPatterns.Proxy
{
    public class AnimationProxy : IAnimation
    {
        protected Film Film = null;
        protected string Photo = "affichage de la photo";

        public void Clic()
        {
            if (Film == null)
            {
                Film = new Film();
                Film.Charge();
            }
            Film.Joue();
        }

        public void Dessine()
        {
            if (Film != null)
                Film.Dessine();
            else
                Dessine(Photo);
        }

        public void Dessine(string photo)
        {
            Console.WriteLine(photo);
        }
    }
}
