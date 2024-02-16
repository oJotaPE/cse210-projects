using System.Text;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    public void AddProfuct(int ammount, Product product, Random random)
    {
        int start = 0;
        while (start != ammount)
        {
            Product newProduct = new Product(random); // Crie uma nova instância de Product
            newProduct.InitializeRandomProduct(random); // Inicialize o novo produto com valores aleatórios
            _products.Add(newProduct); // Adicione o novo produto à lista
            start = start + 1;
        }
        
        
    }
    public double CalculateFinalPrice()
    {
        double finalPrice = 0;

        foreach (Product product in _products)
        {
            finalPrice += product.GetCost();
        }

        //adding shipping
        finalPrice += CalculateShippingCost();
        return finalPrice;
    }
    
    private double CalculateShippingCost()
    {
        if (IsCustomerInUSA())
        {
            return 5.0;
        }
        else
        {
            return 35.0;
        }
    }

    private bool IsCustomerInUSA()
    {
        return _customer.LivesOrNot();
    }

    public void GetPackingLabel()
    {
        // StringBuilder label = new StringBuilder();
        // label.AppendLine($"Packing Label for {_customer.GetName()}: ");
        foreach (Product product in _products)
        {
            Console.WriteLine($"ID: {product.GetId()} - {product.GetName()}, {product.GetQuantity()}");
        }
        // return label.ToString();
    }

    public void GetShippingLabel(Random random)
    {
        Address address = new Address(random);
        // StringBuilder label = new StringBuilder();
        // label.AppendLine($"Shipping Label for {_customer}: ");
        Console.WriteLine(address.MakeAdress());
        
        //  return label.ToString();
    }


}