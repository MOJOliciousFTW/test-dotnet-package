namespace ProjectClassLibrary1;

public class Class1
{
    private double _firstVariable;
    private double _secondVariable;

    public Class1(double firstVariable, double secondVariable = 2.0)
    {
        _firstVariable = firstVariable;
        _secondVariable = secondVariable;
    }

    public double Add()
    {
        return _firstVariable + _secondVariable;
    }

    public void SetA(double firstVariable)
    {
        _firstVariable = firstVariable;
    }

    public void SetB(double secondVariable)
    {
        _secondVariable = secondVariable;
    }
}