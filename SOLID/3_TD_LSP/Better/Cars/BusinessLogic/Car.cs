/// <summary>
/// Summary description for Car
/// </summary>
public abstract class Car
{
    public string? Country { get; set; }
    public int PriceInDollar { get; set; }

    /// <summary>
    /// Calculates the price in Euro based on a fixed conversion rate.
    /// </summary>
    /// <returns>Price in Euro (assuming a fixed conversion rate)</returns>
    public virtual double getPriceInEuro()
    {
        // Replace 1.1 with the actual conversion rate
        return PriceInDollar * 1.068;
    }
}
