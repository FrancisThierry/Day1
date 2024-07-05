// See https://aka.ms/new-console-template for more information
using NotSoGood.BusinessLogic;

IFastFood burgerKing = new BurgerKing();
burgerKing.BoughtedMeatByYear = 1000;
burgerKing.Company = "Burger King Lyon 3";
IFastFood mcDonald = new MacDonald();
mcDonald.BoughtedMeatByYear = 5000;
mcDonald.Company = "Mac Donald Paris V";

Console.WriteLine("{0} has bougthed {1} of meat this year.", mcDonald.Company,mcDonald.BoughtedMeatByYear);

IFastFood veganFood = new VeganFood();
veganFood.BoughtedMeatByYear = 0;
