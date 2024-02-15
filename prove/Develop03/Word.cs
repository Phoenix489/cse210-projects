public class Word {

    //Attributes
    private string _word;

    private Boolean _isHidden;

    //Getter
    public Boolean IsHidden() 
    {
        return _isHidden;
    }

    // Constructor 
    public Word(string word) 
    {
        this._word = word;
        _isHidden = false;
    }

    public override string ToString() 
    {
        return _word;
    }

    public void HideWord()
    {
        // Trim the input word
        string trimmedWord = _word.Trim();

        // Create a new string with the same length as the trimmed input word,
        // replacing each character with an underscore
        string hiddenWord = new string('_', trimmedWord.Length);
        _isHidden = true;
        _word = hiddenWord;
    }
}