using FastFood.BusinessLogic;

IBurgerFood burgerFood = new BurgerKing();
burgerFood.BoughtedMeatByYear = 1000;
burgerFood.City = "Lyon";
burgerFood.Company = "Burger King";

IVeganFood veganFood = new GreenFood();
veganFood.BoughtedSoyaByYear = 1000;
veganFood.Company = "Green Food";
veganFood.City = "Marseilles";

Console.WriteLine("The fastfood {0} spent {1} of meat", burgerFood.Company, burgerFood.BoughtedMeatByYear);
Console.WriteLine("The fastfood {0} spent {1} of soya", veganFood.Company, veganFood.BoughtedSoyaByYear);