var names = new List<string> { "Lucas", "João", "Caio", "Rosen" };
foreach (var name in names)
{
    Console.WriteLine($"Alteramos todos os caracteres do nome {name} para maiúsculo: {name.ToUpper()}");
}

Console.WriteLine();



var NBAnames = new List<string> { "LEBRON", "MICHAEL", "STEPHEN", "GIANNIS" };
foreach (var name in NBAnames)
{
    Console.WriteLine($"Alteramos todos os caracteres do nome {name} para minúsculo: {name.ToLower()}");
}

Console.WriteLine();



var NBAsurnames = new List<string> { "   James   ", "   Jordan   ", "   Curry   ", "   Antetokounmpo   ", "   Malone   ", "   Bryant   " };

NBAsurnames.Sort();
foreach (var name in NBAsurnames)
{
    Console.WriteLine($"{name.Trim()}");
}