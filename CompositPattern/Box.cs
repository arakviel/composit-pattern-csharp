namespace CompositPattern;

// Коробка, яка може містити продукти або інші коробки
public class Box : IComponent
{
    private List<IComponent> _components = new List<IComponent>();

    public void AddComponent(IComponent component)
    {
        _components.Add(component);
    }

    public void RemoveComponent(IComponent component)
    {
        _components.Remove(component);
    }

    public decimal GetPrice()
    {
        decimal totalPrice = 0;
        foreach (var component in _components)
        {
            totalPrice += component.GetPrice();
        }
        return totalPrice;
    }
}
