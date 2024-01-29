// using System.Text;

// public class Scripture
// {
//     //the two single attributes need for this
//     private string _reference;
//     private List<Word> _words;

//     // Outras partes do código...
//     //using the words attribute, choose random words to hide

//     int chosenIndexes = 0; //to make sure it will nor generate more indexes than needed
//     List<int> chosenIndexList = new List<int>(); //List to store the chosen indexes
//     Random random = new Random(); //to create an instance for the random class


//     // public Scripture(string reference, List<string> words)
//     // {
//     //     _reference = reference;
//     //     _words = InitializeWordList(words);
//     // }
//     public Scripture(string reference, List<string> words)
//     {
//         _reference = reference;
//         _words = InitializeWordList(words);
//     }

//     private List<Word> InitializeWordList(List<string> words)
//     {
//         List<Word> wordList = new List<Word>();

//         foreach (string wordText in words)
//         {
//             Word word = new Word(wordText);
//             wordList.Add(word);
//         }

//         return wordList;
//     }

//     public void HideRandomNumbers(int numberToHide)
//     {
//         do
//         {
//             int listSize = _words.Count;
//             int randomIndex = random.Next(0, listSize);
//             chosenIndexList.Add(randomIndex);

//             if (!chosenIndexList.Contains(randomIndex))
//             {
//                 chosenIndexList.Add(randomIndex);
//                 chosenIndexes = chosenIndexes + 1;
//             }
//         } while(chosenIndexes < numberToHide);

//         foreach (Word word in _words)
//         {
//             int wordindex = _words.IndexOf(word);
//             if(chosenIndexList.Contains(wordindex))
//             {
//                 word.Hide(); //PRECISA FAZER ESSE CÓDIGO HIDE AI NA CLASSE WORD
//             }
//         }
//     }

//     public string GetDisplayText()
//     {
//         StringBuilder displayText = new StringBuilder();

//         displayText.Append(_reference);

//         foreach (Word word in _words)
//         {
//             //very if the word is hidden
//             if (word.IsHidden()) //PRECISA CONFIRMAR ESSE IS HIDDEN
//             {
//                 displayText.Append(word.GetDisplayText());
//             }
//             else 
//             {
//             // {   if it's not hidden, just add the real text
//                 displayText.Append(word.GetDisplayText() + " "); // CRIAR ESSE GET DISPLAY TEXT
//             }
//         }

//         return displayText.ToString();
//     }

//     public bool IsCompletelyHidden()
//     {
//         foreach (Word word in _words)
//         {
//             if(!word.IsHidden())
//             {
//                 return false;
//             }   
//         }
//         return true;
//     }
// }
// //     }
// //     public string GetReferenceDisplayText()
// //     {
// //         return _reference.GetDisplayText();
// //     }

// //     public List<string> GetWordsDisplayText()
// //     {
// //         List<string> wordsDisplayText = new List<string>();
// //         foreach (Word word in _words)
// //         {
// //             wordsDisplayText.Add(word.GetDisplayText());
// //         }
// //         return wordsDisplayText;
// //     }
// // }

// public class Scripture
// {
//     private Reference _reference;
//     private List<Word> _words;
//     private Random _random;

//     public Scripture(Reference reference, List<string> words)
//     {
//         _reference = reference;
//         _words = InitializeWordList(words);
//         _random = new Random();
//     }

//     private List<Word> InitializeWordList(List<string> words)
//     {
//         return words.Select(wordText => new Word(wordText)).ToList();
//     }

//     public void HideRandomNumbers(int numberToHide)
//     {
//         for (int i = 0; i < numberToHide; i++)
//         {
//             int randomIndex;
//             do
//             {
//                 randomIndex = _random.Next(0, _words.Count);
//             } while (_words[randomIndex].IsHidden());

//             _words[randomIndex].Hide();
//         }
//     }

//     public string GetDisplayText()
//     {
//         StringBuilder displayText = new StringBuilder();
//         displayText.Append(_reference.GetDisplayText());

//         foreach (Word word in _words)
//         {
//             displayText.Append(word.GetDisplayText() + " ");
//         }

//         return displayText.ToString();
//     }

//     public bool IsCompletelyHidden()
//     {
//         return _words.All(word => word.IsHidden());
//     }
// }
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;

    public Scripture(Reference reference, List<string> words)
    {
        _reference = reference;
        _words = InitializeWordList(words);
        _random = new Random();
    }

    private List<Word> InitializeWordList(List<string> words)
    {
        return words.Select(wordText => new Word(wordText)).ToList();
    }

    public void HideRandomNumbers(int numberToHide)
    {
        for (int i = 0; i < numberToHide; i++)
        {
            int randomIndex;
            do
            {
                randomIndex = _random.Next(0, _words.Count);
            } while (_words[randomIndex].IsHidden());

            _words[randomIndex].Hide();
        }
    }

    public string GetDisplayText()
    {
        StringBuilder displayText = new StringBuilder();
        displayText.Append(_reference.GetDisplayText());

        foreach (Word word in _words)
        {
            displayText.Append(word.GetDisplayText() + " ");
        }

        return displayText.ToString();
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}
