public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    List<string> streets = new List<string>()
    {
        "Main Street",
        "Maple Avenue",
        "Oak Street",
        "Cedar Lane",
        "Pine Street",
        "Elm Avenue",
        "Birch Lane",
        "Poplar Street",
        "Willow Avenue",
        "Hickory Lane",
        "Sycamore Street",
        "Ash Avenue",
        "Cypress Lane",
        "Walnut Street",
        "Cherry Avenue"
    };
    List<string> cities = new List<string>()
    {
        "Birmingham",
        "Anchorage",
        "Phoenix",
        "Los Angeles",
        "Denver",
        "Hartford",
        "Wilmington",
        "Miami",
        "Atlanta",
        "Minneapolis",
        "Jackson",
        "Kansas City",
        "Billings",
        "Chicago",
        "Louisville",
        "New Orleans",
    };
    List<string> states = new List<string>()
    {
        "Alabama",
        "Alaska",
        "Arizona",
        "Arkansas",
        "California",
        "Colorado",
        "Connecticut",
        "Kentucky",
        "Louisiana",
        "Maine",
        "Maryland",
        "Massachusetts",
        "Michigan",
        "Minnesota"
    };

    public Address()
    {
        Random random = new Random();
        _city = cities[random.Next(0, cities.Count)];
        _country = "United States";
        _state = states[random.Next(0, states.Count)];
        _street = streets[random.Next(0, streets.Count)];
    }

    public string GetAddressLine()
    {
        return $"{_street}, {_city}, {_state}, {_country}";
    }
}