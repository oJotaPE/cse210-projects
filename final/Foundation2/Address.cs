public class Address
{
    //setting the properties
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
       // Estados dos Estados Unidos
        "Birmingham",
        "Anchorage",
        "Phoenix",
        "Little Rock",
        "Los Angeles",
        "Denver",
        "Hartford",
        "Wilmington",
        "Miami",
        "Atlanta",
        "Honolulu",
        "Boise",
        "Chicago",
        "Indianapolis",
        "Des Moines",
        "Topeka",
        "Louisville",
        "New Orleans",
        "Portland",
        "Baltimore",
        "Boston",
        "Detroit",
        "Minneapolis",
        "Jackson",
        "Kansas City",
        "Billings",
        "Omaha",
        "Las Vegas",
        "Manchester",
        "Newark",
        "Albuquerque",
        "New York City",
        "Charlotte",
        "Fargo",
        "Columbus",
        "Oklahoma City",
        "Portland",
        "Philadelphia",
        "Providence",
        "Charleston",
        "Sioux Falls",
        "Nashville",
        "Houston",
        "Salt Lake City",
        "Burlington",
        "Virginia Beach",
        "Seattle",
        "Charleston",
        "Madison",
        "Cheyenne",

        // Províncias do Canadá
        "Calgary",
        "Vancouver",
        "Winnipeg",
        "Fredericton",
        "St. John's",
        "Halifax",
        "Toronto",
        "Charlottetown",
        "Québec City",
        "Regina",

        // Estados do Brasil
        "Rio Branco",
        "Maceió",
        "Macapá",
        "Manaus",
        "Salvador",
        "Fortaleza",
        "Vitória",
        "Goiânia",
        "São Luís",
        "Cuiabá",
        "Campo Grande",
        "Belo Horizonte",
        "Belém",
        "João Pessoa",
        "Curitiba",
        "Recife",
        "Teresina",
        "Rio de Janeiro",
        "Natal",
        "Porto Alegre",
        "Porto Velho",
        "Boa Vista",
        "Florianópolis",
        "São Paulo",
        "Aracaju",
        "Palmas",

        // Estados do Reino Unido
        "London",
        "Edinburgh",
        "Cardiff",
        "Belfast",

        // Estados da Alemanha
        "Stuttgart",
        "Munich",
        "Berlin",
        "Potsdam",
        "Bremen",
        "Hamburg",
        "Wiesbaden",
        "Hanover",
        "Schwerin",
        "Düsseldorf",
        "Mainz",
        "Saarbrücken",
        "Dresden",
        "Magdeburg",
        "Kiel",
        "Erfurt",

        // Estados da França
        "Lyon",
        "Besançon",
        "Rennes",
        "Orléans",
        "Ajaccio",
        "Strasbourg",
        "Lille",
        "Paris",
        "Rouen",
        "Bordeaux",
        "Toulouse",
        "Nantes",
        "Nice",

        // Estados da Itália
        "L'Aquila",
        "Aosta",
        "Bari",
        "Potenza",
        "Catanzaro",
        "Naples",
        "Bologna",
        "Trieste",
        "Rome",
        "Genoa",
        "Milan",
        "Ancona",
        "Campobasso",
        "Turin",
        "Cagliari",
        "Palermo",
        "Trento",
        "Florence",
        "Perugia",
        "Venice",

        // Estados da Espanha
        "Seville",
        "Zaragoza",
        "Oviedo",
        "Palma",
        "Bilbao",
        "Las Palmas",
        "Santander",
        "Toledo",
        "Valladolid",
        "Barcelona",
        "Mérida",
        "Santiago de Compostela",
        "Madrid",
        "Murcia",
        "Pamplona",
        "Valencia",

        // Estados da Austrália
        "Canberra",
        "Sydney",
        "Darwin",
        "Brisbane",
        "Adelaide",
        "Hobart",
        "Melbourne",
        "Perth",

        // Estados da Índia
        "Amaravati",
        "Itanagar",
        "Dispur",
        "Patna",
        "Raipur",
        "Panaji",
        "Gandhinagar",
        "Chandigarh",
        "Shimla",
        "Ranchi",
        "Bengaluru",
        "Thiruvananthapuram",
        "Bhopal",
        "Mumbai",
        "Imphal",
        "Shillong",
        "Aizawl",
        "Kohima",
        "Bhubaneswar",
        "Chandigarh",
        "Jaipur",
        "Gangtok",
        "Chennai",
        "Hyderabad",
        "Agartala",
        "Lucknow",
        "Dehradun",
        "Kolkata",

        // Outros países
        "Beijing",
        "Shanghai",
        "Tokyo",
        "Seoul",
        "Moscow"
    };
    List<string> states = new List<string>()
    {
                // Estados dos Estados Unidos
        "Alabama",
        "Alaska",
        "Arizona",
        "Arkansas",
        "California",
        "Colorado",
        "Connecticut",
        "Delaware",
        "Florida",
        "Georgia",
        "Hawaii",
        "Idaho",
        "Illinois",
        "Indiana",
        "Iowa",
        "Kansas",
        "Kentucky",
        "Louisiana",
        "Maine",
        "Maryland",
        "Massachusetts",
        "Michigan",
        "Minnesota",
        "Mississippi",
        "Missouri",
        "Montana",
        "Nebraska",
        "Nevada",
        "New Hampshire",
        "New Jersey",
        "New Mexico",
        "New York",
        "North Carolina",
        "North Dakota",
        "Ohio",
        "Oklahoma",
        "Oregon",
        "Pennsylvania",
        "Rhode Island",
        "South Carolina",
        "South Dakota",
        "Tennessee",
        "Texas",
        "Utah",
        "Vermont",
        "Virginia",
        "Washington",
        "West Virginia",
        "Wisconsin",
        "Wyoming",

        // Províncias do Canadá
        "Alberta",
        "British Columbia",
        "Manitoba",
        "New Brunswick",
        "Newfoundland and Labrador",
        "Nova Scotia",
        "Ontario",
        "Prince Edward Island",
        "Quebec",
        "Saskatchewan",

        // Estados do Brasil
        "Acre",
        "Alagoas",
        "Amapá",
        "Amazonas",
        "Bahia",
        "Ceará",
        "Espírito Santo",
        "Goiás",
        "Maranhão",
        "Mato Grosso",
        "Mato Grosso do Sul",
        "Minas Gerais",
        "Pará",
        "Paraíba",
        "Paraná",
        "Pernambuco",
        "Piauí",
        "Rio de Janeiro",
        "Rio Grande do Norte",
        "Rio Grande do Sul",
        "Rondônia",
        "Roraima",
        "Santa Catarina",
        "São Paulo",
        "Sergipe",
        "Tocantins",

        // Estados do Reino Unido
        "England",
        "Scotland",
        "Wales",
        "Northern Ireland",

        // Estados da Alemanha
        "Baden-Württemberg",
        "Bavaria (Bayern)",
        "Berlin",
        "Brandenburg",
        "Bremen",
        "Hamburg",
        "Hesse (Hessen)",
        "Lower Saxony (Niedersachsen)",
        "Mecklenburg-Vorpommern",
        "North Rhine-Westphalia (Nordrhein-Westfalen)",
        "Rhineland-Palatinate (Rheinland-Pfalz)",
        "Saarland",
        "Saxony (Sachsen)",
        "Saxony-Anhalt (Sachsen-Anhalt)",
        "Schleswig-Holstein",
        "Thuringia (Thüringen)",

        // Estados da França
        "Auvergne-Rhône-Alpes",
        "Bourgogne-Franche-Comté",
        "Brittany (Bretagne)",
        "Centre-Val de Loire",
        "Corsica (Corse)",
        "Grand Est",
        "Hauts-de-France",
        "Île-de-France",
        "Normandy (Normandie)",
        "Nouvelle-Aquitaine",
        "Occitanie",
        "Pays de la Loire",
        "Provence-Alpes-Côte d'Azur",

        // Estados da Itália
        "Abruzzo",
        "Aosta Valley (Valle d'Aosta)",
        "Apulia (Puglia)",
        "Basilicata",
        "Calabria",
        "Campania",
        "Emilia-Romagna",
        "Friuli-Venezia Giulia",
        "Lazio",
        "Liguria",
        "Lombardy (Lombardia)",
        "Marche",
        "Molise",
        "Piedmont (Piemonte)",
        "Sardinia (Sardegna)",
        "Sicily (Sicilia)",
        "Trentino-South Tyrol (Trentino-Alto Adige)",
        "Tuscany (Toscana)",
        "Umbria",
        "Veneto",

        // Estados da Espanha
        "Andalusia (Andalucía)",
        "Aragon (Aragón)",
        "Asturias (Asturias)",
        "Balearic Islands (Islas Baleares)",
        "Basque Country (País Vasco)",
        "Canary Islands (Islas Canarias)",
        "Cantabria (Cantabria)",
        "Castilla-La Mancha",
        "Castilla y León",
        "Catalonia (Cataluña)",
        "Extremadura",
        "Galicia (Galicia)",
        "La Rioja",
        "Madrid",
        "Murcia (Región de Murcia)",
        "Navarre (Comunidad Foral de Navarra)",
        "Valencian Community (Comunidad Valenciana)",

        // Estados da Austrália
        "Australian Capital Territory (ACT)",
        "New South Wales (NSW)",
        "Northern Territory (NT)",
        "Queensland (QLD)",
        "South Australia (SA)",
        "Tasmania (TAS)",
        "Victoria (VIC)",
        "Western Australia (WA)",

        // Estados da Índia
        "Andhra Pradesh",
        "Arunachal Pradesh",
        "Assam",
        "Bihar",
        "Chhattisgarh",
        "Goa",
        "Gujarat",
        "Haryana",
        "Himachal"
    };
    List<string> countries = new List<string>()
    {
        "United States",
        "Canada",
        "Brazil",
        "United Kingdom",
        "Germany",
        "France",
        "Italy",
        "Spain",
        "Australia",
        "India",
        "China",
        "Japan",
        "South Korea",
        "Mexico",
        "Russia"
    };

    //in case no info is given, I have now base values.
    public Address(Random random)
    {
        _city = cities[random.Next(0, cities.Count)];
        _country = countries[random.Next(0, countries.Count)];
        _state = states[random.Next(0, states.Count)];
        _street = streets[random.Next(0, streets.Count)];
    }

    //setters
    public void SetCountry (string country)
    {
        _country = country;
    }
    public void SetState(string state)
    {
        _state = state;
    }
    public void SetCity(string city)
    {
        _city = city;
    }
    public void SetStreet(string street)
    {
        _street = street;
    }

    //getters
    public string GetCountry()
    {
        return _country;
    }
    public string GetState()
    {
        return _state;
    }
    public string GetCity()
    {
        return _city;
    }
    public string GetStreet()
    {
        return _street;
    }

    public bool LivesOrNot()
    {
        bool lives;
        string baseCountry = "United States"; //the only important thing is if the person lives in US or not
        if (_country == baseCountry)
        {
            lives = true; //return true if lives
        }
        else
        {
            lives = false; //return false id doesn't live
        }
        return lives;
    }

    public string MakeAddress()
    {
        return $"adress: \n{_street}, {_city} \n{_state} \n{_country}";
        //return a label with all the fields of the address
    }
}