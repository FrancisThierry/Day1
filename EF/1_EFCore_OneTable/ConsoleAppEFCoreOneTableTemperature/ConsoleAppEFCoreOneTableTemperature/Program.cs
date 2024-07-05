// See https://aka.ms/new-console-template for more information
using ConsoleAppEFCoreOneTableTemperature;

DatabaseOneTableContext ctx = new DatabaseOneTableContext();
//Ajout
ctx.OneTables.Add  (new OneTable { Company = "Mac do", DateCreation = DateTime.Now, Temperature= (decimal?)15.60 });
ctx.SaveChanges ();
//Lecture
foreach (var item in ctx.OneTables)
{
    Console.WriteLine ("Company : {0} Temperature : {1} Date : {2} ",item.Company, item.Temperature, item.DateCreation);
    
}

ctx.Table2s.Add(new Table2 { City = "Belfort" });
ctx.SaveChanges();