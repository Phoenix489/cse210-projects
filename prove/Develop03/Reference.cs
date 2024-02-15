using System.ComponentModel;

public class Reference {

    //Attributes
    private string _greaterBook;

    private string _book;

    private string _chapter;
    
    private string _verses; 

    private string _text;

    //Getters 
    public string GetText() 
    {
        return _text;
    }

    //Default Constructor
    public Reference() 
    {
        _greaterBook = "Bible";
        _book = "John";
        _chapter = "3";
        _verses = "16";
        _text = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
    }
    //Customized Constructor
    public Reference(string greaterBook, string book, string chapter, string verses, string text) 
    {
        this._greaterBook = greaterBook;
        this._book = book;
        this._chapter = chapter;
        this._verses = verses;
        this._text = text;
    }

    //Methods
    override public string ToString() 
    {
        return $"\n {_greaterBook} - {_book} {_chapter}:{_verses}\n";
    }
}