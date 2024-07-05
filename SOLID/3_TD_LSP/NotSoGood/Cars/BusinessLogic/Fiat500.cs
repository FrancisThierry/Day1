using System;

/// <summary>
/// Summary description for Fiat500
/// </summary>
public class Fiat500 : Car
{
    public Fiat500(double _gasMileage) : base(_gasMileage)
    {
    }

    public override double GetGasMileagePrice()
    {
        return base.GetGasMileagePrice() * 7;
    }

   
}
