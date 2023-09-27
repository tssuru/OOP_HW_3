using HW_3_OOP;

var converter = new Converter(36.96m, 38.9m);

Console.WriteLine("Converting 100 UAH to USD: " + converter.UahToUsd(100m));
Console.WriteLine("Converting 100 UAH to EUR: " + converter.UahToEur(100m));
Console.WriteLine("Converting 10 USD to UAH: " + converter.UsdToUah(10m));
Console.WriteLine("Converting 10 EUR to UAH: " + converter.EurToUah(10m));
       