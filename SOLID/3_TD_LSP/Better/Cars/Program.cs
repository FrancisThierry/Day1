using Cars.BusinessLogic;

Zoe zoe = new Zoe();
zoe.Country = "France";
zoe.PriceInDollar = 30000;
zoe.TimeCharging = 4;
Console.WriteLine(zoe.getConsumtionPrice());
Console.WriteLine(zoe.getPriceInEuro());

Fiat500 fiat500 = new Fiat500(400);
fiat500.PriceInDollar = 4000;
fiat500.Country = "Italia";
Console.WriteLine(fiat500.GetGasMileagePrice());
Console.WriteLine(fiat500.getPriceInEuro());
