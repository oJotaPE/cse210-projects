using System;

class Program
{
    static void Main(string[] args)
    {

        Random random = new Random();
        Address address1 = new Address(random);
        Address  address2 = new Address(random);
        
        Customer customer1 = new Customer("John", random);
        Customer customer2 = new Customer("Leah", random);

        
        Product product1 = new Product(random);
        product1.InitializeRandomProduct(random);

        Product product2 = new Product(random);
        product2.InitializeRandomProduct(random);

        Order order1 = new Order(customer1);
        order1.AddProfuct(3, product1, random);

        Order order2 = new Order(customer2);
        order2.AddProfuct(4, product2, random);

        string street1 = address1.GetStreet();
        string city1 = address1.GetCity();
        string state1 = address1.GetState();
        string country1 = address1.GetCountry();

        string street2 = address2.GetStreet();
        string city2 = address2.GetCity();
        string state2 = address2.GetState();
        string country2 = address2.GetCountry();

        string AddressString1 = address1.MakeAddress();
        string addressString2 = address2.MakeAddress();

        // Console.WriteLine(AddressString1);
        // Console.WriteLine("\n------\n");
        // Console.WriteLine(addressString2);
        
        //display names
        Console.WriteLine(customer1.GetName());
        Console.WriteLine($"Packing Label:\n");
        order1.GetPackingLabel();

        Console.WriteLine($"\nShipping Label: \n");
        order1.GetShippingLabel(random);

        Console.WriteLine($"\nTotal Price: {order1.CalculateFinalPrice()}");
        Console.WriteLine("__________\n");

        Console.WriteLine(customer2.GetName());
        Console.WriteLine($"Packing Label:\n");
        order2.GetPackingLabel();

        Console.WriteLine($"\nShipping Label: \n");
         order2.GetShippingLabel(random);

        Console.WriteLine($"\nTotal Price: {order2.CalculateFinalPrice()}");
        Console.WriteLine("__________\n");

    }
}