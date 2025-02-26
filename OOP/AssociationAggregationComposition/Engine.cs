namespace OOP.AssociationAggregationComposition
{
    public class Engine3
    {
        public void Start()
        {
            Console.WriteLine("Engine started");
        }
    }

    public class Car3
    {
        private Engine3 _engine;

        public Car3()
        {
            _engine = new Engine3(); // Composition
        }

        public void Start()
        {
            _engine.Start();
            Console.WriteLine("Car started");
        }
    }
}
