public class Fraction {

// Fields
    private int _numerator;
    private int _denominator;


// Constructors
    public Fraction() 
    {
        _numerator = 1;
        _denominator = 1;
    }

    public Fraction(int wholeNumber) 
    {
        _numerator = wholeNumber;
        _denominator = 1;
    }

    public Fraction(int top, int bottom) 
    {
        _numerator = top;
        _denominator = bottom;
    }

//Getters and Setters
    public int GetNumerator()
    {
        return _numerator;
    }

    public void SetNumerator(int numerator)
    {
        _numerator = numerator;
    }

    public int GetDenominator()
    {
        return _denominator;
    }

    public void SetDenominator(int denominator)
    {
        _denominator = denominator;
    }

//Methods
    public string GetFractionString() 
    {
        return $"{_numerator}/{_denominator}";
    }

    public double GetDecimalValue()
    {
        return (double)_numerator / (double)_denominator;
    }
}