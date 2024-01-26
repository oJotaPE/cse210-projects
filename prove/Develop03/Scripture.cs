using System.Text;

public class Scripture
{
    //the two single attributes need for this
    private string _reference;
    private List<Word> _words;
    //using the words attribute, choose random words to hide

    int chosenIndexes = 0; //to make sure it will nor generate more indexes than needed
    List<int> chosenIndexList = new List<int>(); //List to store the chosen indexes
    Random random = new Random(); //to create an instance for the random class
    
    public void HideRandomNumbers(int numberToHide)
    {
        do
        {
            int listSize = _words.Count;
            int randomIndex = random.Next(0, listSize);
            chosenIndexList.Add(randomIndex);

            if (!chosenIndexList.Contains(randomIndex))
            {
                chosenIndexList.Add(randomIndex);
                chosenIndexes = chosenIndexes + 1;
            }
        } while(chosenIndexes < numberToHide);
        
        foreach (Word word in _words)
        {
            int wordindex = _words.IndexOf(word);
            if(chosenIndexList.Contains(wordindex))
            {
                word.Hide(); //PRECISA FAZER ESSE CÓDIGO HIDE AI NA CLASSE WORD
            }
        }
    }

    public string GetDisplayText()
    {
        StringBuilder displayText = new StringBuilder();

        displayText.Append(_reference);

        foreach (Word word in _words)
        {
            //very if the word is hidden
            if (word.IsHidden()) //PRECISA CONFIRMAR ESSE IS HIDDEN
            {
                displayText.Append("_be_______" );
            }
            else 
            // {   if it's not hidden, just add the real text
                displayText.Append(word.GetDisplayText() + " "); // CRIAR ESSE GET DISPLAY TEXT
            }
        }

        return displayText.ToString();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if(!word.isHidden())
            {
                return false
            }   
        }
        return true;
    }
}