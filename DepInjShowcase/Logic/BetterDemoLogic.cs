namespace DepInjShowcase.Logic
{
    public class DifferentDemoLogic : IDemoLogic
    {
        public int Value1 { get; set; }
        public int Value2 { get; set; }

        public DifferentDemoLogic()
        {
            Value1 = 25;
            Value2 = 50;
        }
    }
}
