using System.ComponentModel.Design;
using System.Security.Cryptography;

public class Scripture 
{
    //Attibutes
    private Reference _reference;

    private List<Word> _wordsInScripture;

    //Constructor
    public Scripture(Reference reference) 
    {
        _reference = reference;
        _wordsInScripture = reference.GetText().Split(' ').Select((w) => new Word(w)).ToList();
    }

    //Method
    public override string ToString()
    {
        string toString = "";
        toString += _reference.ToString();
        toString += "\n";
        toString += String.Join(" ", _wordsInScripture.Select(w => w.ToString()));
        toString += "\n";
        return toString;
    }

    public Boolean IsWholeScriptureHidden() 
    {
        return _wordsInScripture.All(w => w.IsHidden());
    }


    public void HideWords() 
    {
        //Get a random amount of words to Hide
        Random random = new Random();
        int randomAmount = random.Next(3, 6);

        for (int i = 0; i < randomAmount; i++) 
        {
            if (IsWholeScriptureHidden()) 
            {
                break;
            }
            while (true) 
            {
                int randomIndex = random.Next(0, _wordsInScripture.Count);
                if (_wordsInScripture[randomIndex].IsHidden()) 
                {
                    continue;
                }

                else 
                {
                    _wordsInScripture[randomIndex].HideWord();
                    break;
                }
            }
        }
    }
}