using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("1098st", "Boulevard", "CO", "USA");
        Address address2 = new Address("456 Another St", "Othertown", "ON", "Canada");
  
        Customer customer1 = new Customer("Travis Scott", address1);
        Customer customer2 = new Customer("Bob Constructor", address2);

        Product product1 = new Product("Apple", "W001", 800, 2);
        Product product2 = new Product("Orange", "W002", 1500, 1);
        Product product3 = new Product("Coco", "G001", 200, 3);
 
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
     
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: {order1.TotalPrice():C}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: {order2.TotalPrice():C}\n");

    }
}
