namespace SOLID.InterfaceSegregationPrinciple_ISP
{
    public interface IWorkable
    {
        void Work();
    }

    public interface IEatable
    {
        void Eat();
    }

    public class Human : IWorkable, IEatable
    {
        public void Work()
        {
            // Work logic
        }

        public void Eat()
        {
            // Eat logic
        }
    }

    public class Robot : IWorkable
    {
        public void Work()
        {
            // Work logic
        }
    }
}
