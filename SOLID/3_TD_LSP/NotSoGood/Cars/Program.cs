// See https://aka.ms/new-console-template for more information
using Cars.BusinessLogic;

Console.WriteLine("Hello, World!");
Fiat500 fiat500 = new Fiat500(1000);
Console.WriteLine(fiat500.GetGasMileagePrice());

Zoe zoe = new Zoe(0);//plante car GasMileage doit être > 0
Console.WriteLine(zoe.GetGasMileagePrice());// utlise une méthode parente

