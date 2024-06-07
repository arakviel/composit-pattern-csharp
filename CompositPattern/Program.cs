namespace CompositPattern;

// Тестування патерну Компонувальник
public class Program
{
    public static void Main(string[] args)
    {
        // Створення окремих продуктів
        IComponent product1 = new Product("Product 1", 10.00m);
        IComponent product2 = new Product("Product 2", 20.00m);
        IComponent product3 = new Product("Product 3", 30.00m);

        // Створення коробки, яка містить продукти
        Box box1 = new Box();
        box1.AddComponent(product1);
        box1.AddComponent(product2);

        // Створення ще однієї коробки, яка містить продукти та іншу коробку
        Box box2 = new Box();
        box2.AddComponent(product3);
        box2.AddComponent(box1);

        // Вивід цін
        Console.WriteLine($"Price of Product 1: {product1.GetPrice()}");
        Console.WriteLine($"Price of Product 2: {product2.GetPrice()}");
        Console.WriteLine($"Price of Product 3: {product3.GetPrice()}");
        Console.WriteLine($"Price of Box 1: {box1.GetPrice()}");
        Console.WriteLine($"Price of Box 2: {box2.GetPrice()}");
    }
}