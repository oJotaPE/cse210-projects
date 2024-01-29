
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
