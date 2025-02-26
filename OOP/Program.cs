using OOP.Abstraction;
using OOP.AssociationAggregationComposition;
using OOP.ClassesAndObjects;
using OOP.Encapsulation;
using OOP.Inheritance;
using OOP.Polymorphism;

namespace OOP;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Classes And Objects");


        // Create an object
        Car myCar = new Car
        {
            Make = "Toyota",
            Model = "Corolla",
            Year = 2020
        };

        // Use the object
        myCar.Drive(); // Output: Toyota Corolla is driving.

        Console.WriteLine("\nEncapsulation");

        BankAccount bankAccount = new BankAccount();
        bankAccount.Deposit(100);
        bankAccount.Withdraw(50);
        Console.WriteLine($"Balance: {bankAccount.GetBalance()}"); // Output: Balance: 50

        Console.WriteLine("\nInheritance");
        // Usage
        CarBase myInheriCar = new CarBase
        {
            Make = "Toyota",
            Model = "Corolla",
            NumberOfDoors = 4
        };

        myInheriCar.Start(); // Output: Toyota Corolla is starting.
        
        Console.WriteLine("\nPolymorphism | Method Overriding");
        // Usage
        Animal myAnimal = new Dog();
        myAnimal.MakeSound(); // Output: Woof!

        Console.WriteLine("\nPolymorphism | Interface");
        // Usage
        IShape shape = new Circle();
        shape.Draw(); // Output: Drawing a circle


        Console.WriteLine("\nAbstraction");
        // Usage
        ShapeAbstraction shapeAbstraction = new CircleAbstraction();
        shapeAbstraction.Draw(); // Output: Drawing a circle

        Console.WriteLine("\nAssociation, Aggregation, and Composition");
        // Usage
        Car3 myCar3 = new Car3();
        myCar3.Start(); // Output: Engine started, Car started
    }
}
