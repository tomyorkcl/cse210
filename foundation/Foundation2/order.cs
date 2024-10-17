public class Order
{
    private List<Product> products = new List<Product>();
    private Customer customer;
    private const decimal USA_Shipping_Cost = 5m;
    private const decimal International_Shipping_Cost = 35m;

    public Order(Customer customer)
    {
        this.customer = customer;
    }
    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public decimal TotalPrice()
    {
        decimal total = 0;

        foreach (var product in products)
        {
            total += product.TotalCost();
        }

        total += customer.LivesInUSA() ? USA_Shipping_Cost : International_Shipping_Cost;
        return total;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in products)
        {
            label += product.GetProductDetails() + "\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return "Shipping Label:\n" + customer.GetCustomerDetails();
    }
}