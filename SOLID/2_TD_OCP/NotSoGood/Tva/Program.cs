// See https://aka.ms/new-console-template for more information
using Tva.BusinessLogic;


CompanyType type_rstauration = new CompanyType();
type_rstauration.Name = "réduit";

TvaCalculator calculator_tva_reduite = new TvaCalculator();
calculator_tva_reduite.MontantHorsTaxe = 1000;
Console.WriteLine(calculator_tva_reduite.Calculate(type_rstauration));
