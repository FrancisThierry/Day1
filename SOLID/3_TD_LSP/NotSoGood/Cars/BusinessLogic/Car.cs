using System;

/// <summary>
/// Summary description for Car
/// </summary>
public class Car
{

    public double gasMileage { get; set; }
    public Car(double _gasMileage)
    {
        if (_gasMileage <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(_gasMileage), "Gas mileage must be positive.");
        }
        gasMileage = _gasMileage;
    }

    public virtual double GetGasMileagePrice()
    {
        return gasMileage * 8;

    }
}
