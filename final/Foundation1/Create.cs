using System.Dynamic;

public class Create
{
    private string _randomTittle;
    private string _randomAuthor;
    private int _randomLength;


    //just to have default values in a constructor.
    public Create()
    {
        _randomAuthor = "unknown";
        _randomTittle = "Youtube video";
        _randomLength = 0;
    }
    Random random = new Random();    
    
    public void GenerateRandomVideo()
    {
        //calling the video class for each one of the videos required
        Video video01 = new Video(); //1
        Comment comment01 = new Comment();

        video01.SetTittle();
        video01.SetLength();
        video01.SetAuthor();
        video01.Display();

        comment01.SetUser();
        comment01.SetText();
        comment01.Display();


        Video video02 = new Video(); //2
        Comment comment02 = new Comment();

        video02.SetTittle();
        video02.SetLength();
        video02.SetAuthor();
        video02.Display();

        comment02.SetUser();
        comment02.SetText();
        comment02.Display();

        Video video03 = new Video(); //3
        Comment comment03 = new Comment();

        video03.SetTittle();
        video03.SetLength();
        video03.SetAuthor();
        video03.Display();

        comment03.SetUser();
        comment03.SetText();
        comment03.Display();
        Video video04 = new Video(); //4
        Comment comment04 = new Comment();

        video04.SetTittle();
        video04.SetLength();
        video04.SetAuthor();
        video04.Display();

        comment04.SetUser();
        comment04.SetText();
        comment04.Display();
    }
}