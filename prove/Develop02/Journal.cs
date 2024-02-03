
using System.Security.Cryptography.X509Certificates;

public class Journal {

    public string[] _loadedFileLines = [];

    private List<Entry> _entries = new List<Entry>(); 

    public string Display()
    {
        string displayString = "";
        foreach (string line in _loadedFileLines) {
            displayString += line; 
            displayString += "\n"; 
        }

        foreach (Entry entry in _entries) {
            displayString += entry.Display();
            displayString += "\n"; 
        }

        return displayString.Substring(0, displayString.Length - 1);
    }

    public void AddEntry(string text, string prompt, string date, string lunch) {
        Entry tempEntry = new Entry();
        tempEntry._text = text;
        tempEntry._prompt = prompt;
        tempEntry._date = date;
        tempEntry._lunch = lunch;
        _entries.Add(tempEntry);
    }

}