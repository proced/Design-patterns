namespace lp73.designPatterns.Proxy
{
    public partial class VueVehicule
    {
      public  static void Proxy()
  {
    IAnimation animation = new AnimationProxy();
    animation.Dessine();
    animation.Clic();
    animation.Dessine();
  }
   
    }
}
