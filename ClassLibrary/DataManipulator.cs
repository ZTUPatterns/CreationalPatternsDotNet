namespace ClassLibrary
{
    public class DataManipulator
    {
        protected IAbstractFactory factory;
        public DataManipulator(IAbstractFactory abstractFactory)
        {
            factory = abstractFactory;
        }
        public void DoCalculation()
        {
            var reader = factory.CreateReader();
            var writer = factory.CreateWriter();
            int a = reader.ReadInt();
            double b = reader.ReadDouble();
            double result = a * a * b * Math.Cos(a);
            writer.WriteDouble(result);
        }
    }
}