using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class ReducedTva : ITvaCalculator
{
    public ReducedTva()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public double  Amount { get; set; }


    public double Calculate()
    {
        return (Amount/100) * 5.5;
    }

  
}
