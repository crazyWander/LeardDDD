namespace ConsoleApp2.Products;

public class Product
{
    public Guid Id { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public Money Price { get; private set; }
    public Sku Sku { get; private set; }
}

public record Sku
{
    private Sku(string value) => Value = value;
    private const int DefaultLenght = 15;
    public string Value { get; init; }

    public static Sku? Create(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            return null;
        }

        return value.Length != DefaultLenght ? null : new Sku(value);
    }
}