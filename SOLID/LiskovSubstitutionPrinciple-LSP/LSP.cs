namespace SOLID.LiskovSubstitutionPrinciple_LSP
{
    public abstract class Bird
    {
    }

    public class FlyingBird : Bird
    {
        public virtual void Fly()
        {
            // Fly logic
        }
    }

    public class Ostrich : Bird
    {
        // No Fly method
    }
}
