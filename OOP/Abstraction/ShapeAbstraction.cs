namespace OOP.Abstraction
{
    public abstract class ShapeAbstraction
    {
        public abstract void Draw(); // Abstract method (no implementation)
    }

    public class CircleAbstraction : ShapeAbstraction
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle");
        }
    }
}
