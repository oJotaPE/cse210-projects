public class Customer
{
    //setting the properties
    private string _name;
    private bool _livesInUS;
    private Address _address;

    public Customer(Random random)
    {
        _name = "unknown";
        _livesInUS = true;
        _address = new Address(random);
    }

    public Customer(string name, Random random)
    {
        _name = name;
        _livesInUS = true;
        _address = new Address(random);
    }

    public bool LivesOrNot()
    {
         _livesInUS = _address.LivesOrNot();
         return _livesInUS;
    }
    public string GetName()
    {
        return _name;
    }

}