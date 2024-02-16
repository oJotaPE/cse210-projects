public class Product
{
    private string _name;
    private string _id;
    private double _price;
    private int _quantity;
    private double _totalCost;
    

    private List<string> products = new List<string>
        {
            "Detergent",
            "Paper Towels",
            "Toothpaste",
            "Shampoo",
            "Cereal",
            "Coffee",
            "Laundry Detergent",
            "Soap",
            "Toilet Paper",
            "Trash Bags"
        };

    private List<string> productIds = new List<string>
        {
            "ll12345",
            "bp67890",
            "up54321",
            "pcdb98765",
            "pt11111",
            "pl22222",
            "yh33333",
            "hh444",
            "y55555",
            "t66666"
        };

    private List<double> prices = new List<double>
        {
            2.99,
            3.49,
            1.99,
            5.99,
            2.49,
            7.99,
            4.99,
            1.79,
            6.99,
            8.49
        };

    //constructor
    // public Product()
    // {
    //     _id = "none";
    //     _name = "none";
    //     _price = 0;
    //     _quantity = 0;
    //     _totalCost = 0;
    // }

    // Random random = new Random();

    // public void InitializeRandomProduct()
    // {
    //     int randomIndex = random.Next(0, products.Count);
    //     int randomQuantity = random.Next(1, 15);
    //     _name = products[randomIndex];
    //     _id = productIds[randomIndex];
    //     _price = prices[randomIndex];
    //     _quantity = randomQuantity;
    //     _totalCost = _price * _quantity;
    // }
    // Constructor
    public Product(Random random)
    {
        InitializeRandomProduct(random);
    }

    public void InitializeRandomProduct(Random random)
    {
        int randomIndex = random.Next(0, products.Count);
        int randomQuantity = random.Next(1, 15);

        _name = products[randomIndex];
        _id = productIds[randomIndex];
        _price = prices[randomIndex];
        _quantity = randomQuantity;
        _totalCost = _price * _quantity;
    }

    public string GetName()
    {
        return _name;
    }
    public string GetId()
    {
        return _id;
    }
    public int GetQuantity()
    {
        return _quantity;
    }
    public double GetPrice()
    {
        return _price;
    }
    public double GetCost()
    {
        return _totalCost;
    }

}