using SimpleCQRS;

namespace CQRSGui
{
    public static class ServiceLocator
    {
        public static FakeBus Bus { get; set; }
       
    }

   public static class Derived
    {
        public static string c;
    }
}