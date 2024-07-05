using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class NormalTva : ITvaCalculator
{
    public NormalTva()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public double Amount { get; set; }


    public double Calculate()
    {
        return (Amount / 100) * 10;
    }


}
