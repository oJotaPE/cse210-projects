public class Video
{
    private string _tittle;
    private string _author;
    private int _length;

    public Video()
    {
        _author = "unkown";
        _tittle = "Youtube video";
        _length = 0;
    }
    //Listing all the possibilities to generate random values
    List<string> tittles = new List<string>
    {
        "Exploring Hidden Waterfalls",
        "Cooking Delicious Vegan Recipes",
        "Gaming Marathon: Best Moments",
        "Travel Vlog: A Day in Paris",
        "Tech Review: Latest Gadgets",
        "Fitness Workout Routine for Beginners",
        "DIY Home Decor Ideas",
        "Learning a New Language: Tips and Tricks",
        "Funny Cat Compilation",
        "Photography Tips for Stunning Shots",
        "Music Production Tutorial: Making Beats",
        "Book Review: Must-Read Novels",
        "Fashion Haul: Latest Trends",
        "Coding Tutorial: Building a Website",
        "Epic Outdoor Adventures",
        "Healthy Plant-Based Meals",
        "Ultimate Gaming Tips and Tricks",
        "Journey Through Historical Landmarks",
        "Cutting-Edge Tech Innovations",
        "Full-Body Workout Challenge",
        "Creative DIY Craft Projects",
        "Mastering a New Programming Language",
        "Cute and Funny Dog Moments",
        "Mastering the Art of Photography",
        "Creating Electronic Music Masterpieces",
        "Exploring Classic Literature",
        "Top Fashion Trends Unboxed",
        "Web Development for Beginners",
        "Mindful Yoga for Relaxation",
        "Thrilling Mountain Climbs",
        "Delicious and Nutritious Smoothie Recipes",
        "Top PC Games Review",
        "A Cultural Journey: Local Markets",
        "Latest Mobile Gadgets Unveiled",
        "HIIT Workout for Maximum Results",
        "DIY Upcycled Home Decor",
        "Unlocking Language Learning Secrets",
        "Adorable Baby Animal Compilation",
        "Capturing Sunsets: Photography Guide",
        "Creating Your Podcast: Step by Step",
        "Exploring Sci-Fi Book Classics",
        "Runway-Worthy Fashion Haul",
        "Responsive Web Design Tutorial",
        "Meditation Techniques for Beginners",
        "Extreme Sports and Adrenaline Rush",
        "Vegan Dessert Recipes for Sweet Tooth",
        "Indie Game Gems Review",
        "Discovering Hidden Gems in the City",
        "Latest Wearable Tech Gadgets",
        "Pilates Core Strengthening Routine",
        "Upcycled Furniture DIY Projects",
        "Virtual Reality in Gaming",
        "Outdoor Yoga Retreat Experience",
        "Exploring World Cuisine: Cooking Series",
        "Retro Video Games Review",
        "Artistic DIY Wall Painting Ideas",
        "Mastering Advanced Programming Concepts",
        "Wholesome Pet Adoption Stories",
        "Night Sky Photography Tips",
        "Behind the Scenes of Music Production",
        "Classic Mystery Novels Book Club",
        "Edgy Streetwear Fashion Haul",
        "Data Science Tutorial: Hands-On Approach",
        "Nature Sounds Meditation Journey",
        "Mindfulness Meditation for Stress Relief",
    };

    //the idea here is to have two lists, and in the method, I plan to randomply choose one 
    //from each list and have a random author name
    List<string> firstNames = new List<string>
    {
        "John",
        "Mark",
        "Emma",
        "Olivia",
        "Sophia",
        "Liam",
        "Noah",
        "Ava",
        "Isabella",
        "Ethan",
        "Master of",
        "The Genius",
        "Explorer",
        "Adventurer",
        "Guru",
        "Enthusiast of",
        "Traveler from",
        "Dreaming with "
    };
    List<string> secondNames = new List<string>
    {
        "Travels",
        "Laughs",
        "Tech",
        "Journey",
        "Explorer",
        "Adventures",
        "Gaming",
        "Innovation",
        "Crafting",
        "Dreams",
        "Achievements",
        "Creativity",
        "Expertise",
        "Pioneer",
        "Inspiration",
        "Discovery",
        "Storytelling",
        "Education",
        "Entertainment",
        "Fun"
    };


    List<int> lengths = new List<int>
    {
        300,  // 5 minutes
        600,  // 10 minutes
        900,  // 15 minutes
        1200, // 20 minutes
        1800, // 30 minutes
        2400, // 40 minutes
        2700, // 45 minutes
        3000, // 50 minutes
        3600, // 1 hour
    };


    public string GetTittle()
    {
        return _tittle;
    }
    public string GetAuthor()
    {
        return _author;
    }
    public int GetLength()
    {
        return _length;
    }

    Random random = new Random();

    public void SetTittle()
    {
        int randomIndex = random.Next(0, tittles.Count); //this tittles.count thing is to have the length of the list, next will choose a random int number between 0 and the total number of my list
        _tittle = tittles[randomIndex];

    }
    public void SetAuthor()
    {
        int randomFirst = random.Next(0, firstNames.Count); //get a random index
        int randomSecond = random.Next(0, secondNames.Count);//of each list

        string randomAuthor = $" {firstNames[randomFirst]} {secondNames[randomSecond]}";
        _author = randomAuthor;
    }
    public void SetLength()
    {
        int randomIndex = random.Next(0, lengths.Count);
        _length = lengths[randomIndex];
    }

    //get a display for each video data generated
    public void Display()
    {
        Console.WriteLine("______________________________________________");
        Console.WriteLine($"\nTittle: {_tittle} \nAuthor: {_author} \nLength (seconds): {_length}");
        Console.WriteLine("______________________________________________\n");
        
    }

}