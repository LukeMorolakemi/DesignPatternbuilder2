// Example usage
using DesignPattern2.Implementation;

public class BuilderPatternExample
{
    static void Main(string[] args)
    {
        ConcreteItem item = new ConcreteItem.ItemBuilder()
            .SetName("Biscuit")
            .SetPacking(new Wrapper())
            .SetPrice(10.0f)
            .Build();

        Console.WriteLine($"Product: {item.Name()}");
        Console.WriteLine($"Packing: {item.Packing().Pack()}");
        Console.WriteLine($"Price: {item.Price()}");
    }
}