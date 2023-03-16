using ConsoleApp2.Customers;
using ConsoleApp2.Products;

namespace ConsoleApp2.Orders;

public class Order
{
    private readonly HashSet<LineItem> _lineOrders = new();

    private Order() { }
    public Guid Id { get; private set; }
    public Guid CustomerID { get; private set; }

    public static Order Create(Customer customer)
    {
        var order = new Order()
        {
            Id = Guid.NewGuid(),
            CustomerID = customer.id
        };
        return order;
    }

    public void Add(Product product)
    {
        var lineItem = new LineItem(Guid.NewGuid(), Id, product.Id, product.Price);
        _lineOrders.Add(lineItem);
    }
}

public class LineItem
{
    internal LineItem(Guid id, Guid orderId, Guid productId, Money prise)
    {
        Id = id;
        OrderID = orderId;
        ProductID = productId;
        Prise = prise;
    }

    public Guid Id { get; private set; }
    public Guid OrderID { get; private set; }
    public Guid ProductID { get; private set; }
    public Money Prise { get; private set; }
}