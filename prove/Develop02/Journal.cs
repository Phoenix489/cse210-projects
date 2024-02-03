
using System.Security.Cryptography.X509Certificates;

public class Journal {

    public string[] loadedFileLines = [];

    private List<Entry> entries = new List<Entry>(); 

    public string Display()
    {
        string displayString = "";
        foreach (string line in loadedFileLines) {
            displayString += line; 
            displayString += "\n"; 
        }

        foreach (Entry entry in entries) {
            displayString += entry.Display();
            displayString += "\n"; 
        }

        return displayString.Substring(0, displayString.Length - 1);
    }

    public void AddEntry(string text, string prompt, string date) {
        Entry tempEntry = new Entry();
        tempEntry._text = text;
        tempEntry._prompt = prompt;
        tempEntry._date = date;
        entries.Add(tempEntry);
    }

}