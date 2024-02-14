public class Comment
{
    private string _user;
    private string _text;

    private List<string> _comments;

    //lists to generate users
    List<string> userNames = new List<string>
    {
        "mrpenguin",
        "doctorbuilder",
        "singlemouse",
        "codingmaster",
        "explorer123",
        "gamer456",
        "artist789",
        "techwizard",
        "booklover",
        "musicfanatic",
        "Waterbottle",
        "adventurecoder",
        "gadgetgeek",
        "funnyexplorer",
        "digitalartist",
        "languagelearner",
        "codingwhiz",
        "outdooradventurer",
        "wellnessseeker",
        "sciencebuff",
        "virtualwanderer",
        "filmcritic",
        "petlover",
        "historyenthusiast",
        "travellingfoodie",
        "mindfuldeveloper",
        "photographylover",
        "literaturelover",
        "fashionicon",
        "codingenthusiast",
        "historybuff",
        "culinaryexpert",
        "mindfulnessguru",
        "travelenthusiast",
        "petcaregiver",
        "gamingpro",
        "artenthusiast",
        "languageaficionado",
        "healthandwellness",
        "moviereviewer",
        "naturelover"
    };
    List<string> userNumbers = new List<string>
    {
        "123",
        "456",
        "789",
        "234",
        "567",
        "890",
        "345",
        "678",
        "901",
        "321",
        "654",
        "987",
        "432",
        "765",
        "098",
        "456",
        "789",
        "234",
        "567",
        "890",
        "345",
        "678",
        "901",
        "1234",
        "5678",
        "9012"
    };
    //lists to generate comments
    List<string> introductions = new List<string>
    {
        "Liked the content a lot, especially",
        "Didn't agree with everything, but",
        "Impressive! I highlight",
        "Terrible video! Didn't like",
        "Loved the approach to",
        "Expected more, especially",
        "Fully agree with",
        "Found the discussion about",
        "The video made me reflect on",
        "Won't waste more time with videos about",
        "Got excited about",
        "The most interesting part was",
        "My constructive feedback includes",
        "Didn't like the tone used to talk about",
        "Would like to see more approaches to",
    };
    List<string> genericFeedback = new List<string>
    {
        "The presenter is very funny.",
        "Found the content very boring.",
        "The first minute was completely mute.",
        "The video quality is incredible.",
        "The topic discussed is quite interesting.",
        "I got bored during playback.",
        "The video editing is very well done.",
        "The channel always delivers great content.",
        "The images used are very impactful.",
        "The audio of the video is too low.",
        "Found the introduction a bit too long.",
        "The video made me laugh several times.",
        "The pace of the video is too fast.",
        "The end of the video was disappointing.",
        "The graphics used are impressive.",
        "The presenter seems to not master the subject.",
        "The duration of the video is perfect.",
        "The chosen soundtrack doesn't fit.",
        "The content is extremely useful.",
        "I was surprised by the twist at the end.",
        "The lighting of the video could be better.",
        "The narrative is engaging from beginning to end.",
        "The video is very informative.",
        "The presenter's tone of voice is pleasant.",
        "Found the approach original and creative.",
        "The video could have been more objective.",
        "Liked the way the content was structured.",
        "The channel always surprises with novelties.",
        "The video made me reflect on the topic.",
        "The number of ads is annoying.",
    };
    List<string> conclusions = new List<string>
    {
        "Would recommend to a friend!",
        "Unsubscribed from the channel after this video.",
        "I might watch it again.",
        "I don't get the hype around this channel.",
        "Got curious to see more videos.",
        "The content doesn't match the title.",
        "Gained a new subscriber!",
        "I'll share it on my social media.",
        "This video made me waste my time.",
        "Expected more, but still liked it.",
        "Found the analysis too superficial.",
        "Exactly what I was looking for.",
        "Disappointing, not recommended.",
        "Best video I've seen on the channel.",
        "Needs improvement in several aspects.",
    };
    List<string> expressions = new List<string>
    {
        "Terrible video",
        "Loved it",
        "Flamingo",
        "#IWant",
        "Incredible",
        "More of the same",
        "Too good",
        "Lacked depth",
        "Nothing to add",
        "Congratulations",
        "I'm surprised",
        "Didn't like it",
        "Great approach",
        "Got confused",
        "Sensational",
        "Want more videos like this",
        "Unsatisfied",
        "Boring",
        "Excellent",
        "I fully agree",
        "Nonsense",
        "Reasonable",
        "Expected more",
        "Amazing",
    };

    Random random = new Random();

    public Comment()
    {
        _text = "None";
        _user = "unknown";
        _comments = new List<string>();
    }

    public void SetUser()
    {
        int nameIndex = random.Next(0, userNames.Count);
        int numberIndex = random.Next(0, userNumbers.Count);

        string userName = $"{userNames[nameIndex]}{userNumbers[numberIndex]}";
        _user = userName;
    }
    
    public string GetUser()
    {
        return _user;
    }

    public void SetText()
    {
        string comment = "";
        int simpleOrComplex = random.Next(0,2);
        if (simpleOrComplex < 1)
        {
            int expressionIndex = random.Next(0, expressions.Count);
            comment = $"\n   {expressions[expressionIndex]}";
        }
        else
        {
            int introductionIndex = random.Next(0, introductions.Count);
            int argumentIndex = random.Next(0, genericFeedback.Count);
            int conclusionIndex = random.Next(0, conclusions.Count);

            comment = $"\n   {introductions[introductionIndex]} {genericFeedback[argumentIndex]} {conclusions[conclusionIndex]}";;
        }
        _text = comment;
    }

    public string GetText()
    {
        return _text;
    }

    public void SetComments()
    {
        int commentsAmmount = 4;
        _comments.Clear();

        for (int i = 0; i < commentsAmmount; i++)
        {
            SetUser();
            SetText();
                        
            _comments.Add(GetUser());
            _comments.Add(GetText());
            _comments.Add("----");
        }
    }

    public List<string> getComments()
    {
        return _comments;
    }

}

