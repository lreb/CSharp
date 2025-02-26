namespace OOP.Inheritance
{
    // Base class
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }

        public void Start()
        {
            Console.WriteLine($"{Make} {Model} is starting.");
        }
    }

    // Derived class
    public class CarBase : Vehicle
    {
        public int NumberOfDoors { get; set; }
    }
}
