namespace OOP.ClassesAndObjects
{
    public class Car
    {
        // Properties (attributes)
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        // Method (behavior)
        public void Drive()
        {
            Console.WriteLine($"{Make} {Model} is driving.");
        }
    }
}
