public class Entry {

    public string _date;

    public string _text;

    public string _prompt;

    public string Display() {
        return $"\nDate: {_date} - Prompt: {_prompt}\nEntry: {_text}\n";
    }
}
