// public class Word
// {
//     private string _text;
//     private bool _isHidden;


//     //building constructors
//     public Word(string text)
//     {
//         _text = text;
//         _isHidden = false; //initially, the word isn't hidden
//     }
//     //the only function here is to make sure the words will be create code to make it show the words
//     public void Show()
//     {
//         _isHidden = false;

//     }

//     //the only function here is to make sure the words will be create code to make it hide the words
//     public void Hide()
//     {
//         _isHidden = true;
//     }

//     public bool IsHidden()
//     {
//         return _isHidden;
//     }

//     public string GetDisplayText()
//     {
//         if (_isHidden)
//         {
//             return new string ('_', _text.Length);
//         }
//         else
//         {
//             return _text;
//         }
//     }

// }
public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        return _isHidden ? new string('_', _text.Length) : _text;
    }
}
